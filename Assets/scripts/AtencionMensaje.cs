using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtencionMensaje : MonoBehaviour
{
    private bool mensajeActivo = true;
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ScreenLevel2()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Escape) && mensajeActivo)
        {
            desactivarMensaje();
            mensajeActivo = false;
        }
    }


    public void desactivarMensaje()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
