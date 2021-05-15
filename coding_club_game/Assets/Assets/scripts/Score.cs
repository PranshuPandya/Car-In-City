using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(-1*player.position.z);
        scoreText.text = (-1*player.position.z).ToString("0");

    }
}
