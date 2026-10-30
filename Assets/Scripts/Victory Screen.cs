using UnityEngine;

public class VictoryScreen : MonoBehaviour
{

    [SerializeField] GameObject victoryScreen;
    [SerializeField] GameObject pauseScreen;
    [SerializeField] GameObject timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            victoryScreen.SetActive(true);
            pauseScreen.SetActive(false);
            timerText.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}
