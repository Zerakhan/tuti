using UnityEngine;
using UnityEngine.SceneManagement;

public class AlgoPasa : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("New Scene");
        }

    }
}
