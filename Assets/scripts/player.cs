using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;

    public MensajeSalto screen;
    public AtencionMensaje pantalla;
    public win escenaFinal;

    bool isJumping = false;
    [Range(1,500)] public float potenciaSalto;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()

    {
        MovimientoJugador();

        SaltoJugador();
    }


    private void OnCollisionEnter(Collision collision)
    {
        MuerteJugador(collision);

        JumpMensaje(collision);

        ColisionSaltoJugador(collision);

        MensajeAdvertencia(collision);

        FinDelJuego(collision);
    }

   


    private void MovimientoJugador()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);
    }

    private void SaltoJugador()
    {
        if (Input.GetKey(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector3.up * potenciaSalto);
            isJumping = true;
        }
    }


    private void ColisionSaltoJugador(Collision collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            isJumping = false;
            rb.velocity = new Vector3(rb.velocity.x, 0, 0);
        }
    }

    private void JumpMensaje(Collision collision)
    {
        if (collision.gameObject.CompareTag("mensaje salto"))
        {
            screen.ScreenJump();
        }
    }

    private void MensajeAdvertencia(Collision collision)
    {
        if (collision.gameObject.CompareTag("advertencia"))
        {
            pantalla.ScreenLevel2();
        }
    }

    private static void MuerteJugador(Collision collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            Debug.Log("Colision con KIll");
            SceneManager.LoadScene(0);

        }


        if (collision.gameObject.CompareTag("enemigo"))
        {
            Debug.Log("colision con enemigo");
            SceneManager.LoadScene(0);

        }
    }

    private void FinDelJuego(Collision collision)
    {
        if (collision.gameObject.CompareTag("final"))
        {
            escenaFinal.PantallaFinal();
        }
    }
}
    




