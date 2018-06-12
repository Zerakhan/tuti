using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasos : MonoBehaviour {

    public AudioSource Pie_;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Suelo")
        {
            Pie_.Play();
        }
    }
}
