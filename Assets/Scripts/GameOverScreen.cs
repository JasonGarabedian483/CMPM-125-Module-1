using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
