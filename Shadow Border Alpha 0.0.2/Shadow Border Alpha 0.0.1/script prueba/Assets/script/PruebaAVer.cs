using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaAVer : MonoBehaviour {
    public GameObject IMG1;
    public Animator Anim;
    private void Start()
    {
        IMG1.SetActive(false);
        Anim = GetComponent<Animator>();
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
            //Aqui se supone que hace cosas..., Need halp. Anim.SetTrigger (XAnimación);(Creo...)
        }
    }
    void OnTriggerExit(Collider other)
    {
        IMG1.SetActive(false);
    }
}
