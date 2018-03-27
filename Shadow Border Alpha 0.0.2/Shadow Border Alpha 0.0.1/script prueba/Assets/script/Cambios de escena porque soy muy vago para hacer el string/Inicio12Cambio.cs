using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Inicio12Cambio : MonoBehaviour
{
    public int paso = 0;
    public int PasoPerClick = 1;
    public GameObject IMG1;
    public GameObject IMG2;
    public GameObject IMG3;
    public GameObject IMG4;

    private void Start()
    {
        IMG1.SetActive(false);
        IMG2.SetActive(false);
        IMG3.SetActive(false);
        IMG4.SetActive(false);
    }

    public void Pasalo()
    {
        paso = paso + PasoPerClick;


        if (paso == 1)
        {
            IMG1.SetActive(true);
            IMG2.SetActive(false);
            IMG3.SetActive(false);
            IMG4.SetActive(false);
        }
        if (paso == 2)
        {
            IMG1.SetActive(false);
            IMG2.SetActive(true);
        }
        if (paso == 3)
        {
            IMG2.SetActive(false);
            IMG3.SetActive(true);
        }
        if (paso == 4)
        {
            IMG3.SetActive(false);
            IMG4.SetActive(true);
        }
        if (paso == 5)
        {
            SceneManager.LoadScene("1");
        }
    }
}