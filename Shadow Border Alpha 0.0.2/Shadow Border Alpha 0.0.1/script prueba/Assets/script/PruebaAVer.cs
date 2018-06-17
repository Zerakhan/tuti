using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaAVer : MonoBehaviour {
    public GameObject IMG1;
    public GameObject Puente;
    private void Start()
    {
        IMG1.SetActive(false);
        Puente.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IMG1.SetActive(true);
        
        }

    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.R))
        {
            Puente.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        IMG1.SetActive(false);
    }
}
