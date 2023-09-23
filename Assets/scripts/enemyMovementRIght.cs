using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyMovementRight : MonoBehaviour
{
    float velocidad = 0.5f;
    public float distancia = 10.0f;

    private Vector3 incioPosicion;
    private Vector3 objetivoPosicion;
    void Start()
    {
        incioPosicion = transform.position;
        objetivoPosicion =transform.position +Vector3.right*distancia;

    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time * velocidad, 1.0f);
        transform.position= Vector3.Lerp(incioPosicion, objetivoPosicion, t);
    }
}
