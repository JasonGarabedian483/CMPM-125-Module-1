using UnityEngine;

public class KeyCollection : MonoBehaviour
{
    [SerializeField] GameObject victoryWall;
    [SerializeField] Material newMaterial;
    [SerializeField] GameObject unlockText;
    [SerializeField] GameObject LockText;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collected.");
            gameObject.SetActive(false);
            victoryWall.GetComponent<Renderer>().material = newMaterial;
            victoryWall.gameObject.tag = "Ground";
            unlockText.SetActive(true);
            LockText.SetActive(false);

        }
    }
}
