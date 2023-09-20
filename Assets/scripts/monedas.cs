using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedas : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("jugador"))
        {
            score scoreManager = FindObjectOfType<score>();

            scoreManager.AddScore(10);
            Destroy(gameObject);
        }
    }
}
