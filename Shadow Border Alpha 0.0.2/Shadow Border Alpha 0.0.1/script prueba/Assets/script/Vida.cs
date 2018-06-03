using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour {

bool Life;

	// Use this for initialization
	void Start () {
        Life = true;
	}

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Life = false;

        }

        if (Life == false)
        {
            Debug.Log("Scene Loaded");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}