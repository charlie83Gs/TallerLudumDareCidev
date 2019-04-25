using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanDie : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "trap"){
            Debug.Log("death");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            // my codigo de muerte del jugador
        }
    }
}
