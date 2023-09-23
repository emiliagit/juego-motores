using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void PantallaFinal()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}
