using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedas : MonoBehaviour
{
    float rotationSpeed = 50.0f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

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
