using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finale : MonoBehaviour
{
    public int paso = 0;
    public int PasoPerClick = 1;
    // Use this for initialization
    void Start()
    {

    }

    public void pasalo()
    {
        paso = paso + PasoPerClick;


        if (paso == 1)
        {
            SceneManager.LoadScene("New Scene");
        }
    }
}
