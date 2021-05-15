using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool ended = false;
    public float restartDelay = 0.5f;

    public GameObject completeLevelUi;
    
    public void completeLevel()
    {
        completeLevelUi.SetActive(true);
        Invoke("nextScene", 2f);

    }
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EndGame()
    {
        if(ended == false)
        {
            ended = true; 
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            //Restart();
        }
       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
