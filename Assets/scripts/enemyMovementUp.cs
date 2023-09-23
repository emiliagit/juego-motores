using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementUp : MonoBehaviour
{
    float velocidad = 0.5f;
    public float distancia = 10.0f;

    private Vector3 incioPosicion;
    private Vector3 objetivoPosicion;
    void Start()
    {
        incioPosicion = transform.position;
        objetivoPosicion = transform.position + Vector3.up * distancia;

    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time * velocidad, 1.0f);
        transform.position = Vector3.Lerp(incioPosicion, objetivoPosicion, t);
    }
    

}
