using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPorCaida : MonoBehaviour {

    void Update () {
    
     if (gameObject.transform.position.y <= 0)
      SceneManager.LoadScene("2");
    }
}
