using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioCambio : MonoBehaviour
{
    public int paso = 0;
    public int PasoPerClick = 1;

    public void pasalo()
    {
        paso = paso + PasoPerClick;
        if (paso > 0)
        {
            SceneManager.LoadScene("Inicio2");
        }
    }
}
