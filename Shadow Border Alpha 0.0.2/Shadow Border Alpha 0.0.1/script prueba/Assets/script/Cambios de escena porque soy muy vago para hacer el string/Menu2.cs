using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2 : MonoBehaviour
{
    public int paso = 0;
    public int PasoPerClick = 1;

    public void Pasalo()
    {
        paso = paso + PasoPerClick;

        if (paso == 1)
        {
         SceneManager.LoadScene("1");
        }
    }
}
