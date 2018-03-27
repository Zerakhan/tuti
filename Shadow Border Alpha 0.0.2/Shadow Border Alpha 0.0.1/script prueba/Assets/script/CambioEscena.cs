using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    [SerializeField] private string loadlevel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
         SceneManager.LoadScene(loadlevel);
        }
           
    }
}