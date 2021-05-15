using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() => testing();

    private void testing()
    {
        gameManager.completeLevel();
    }
}
