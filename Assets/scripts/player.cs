using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;

    public win screen;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);

    }



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("kill"))
        {

            SceneManager.LoadScene(0);

        }
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            Debug.Log("choque con:" + collision.gameObject.name);

            SceneManager.LoadScene(0);

        }
        if(collision.gameObject.CompareTag("final"))
        {
            screen.activeScreen();
        }

    }
    
}
    




