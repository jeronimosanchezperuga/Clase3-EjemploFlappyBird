using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstablecerPosicionAlAzar : MonoBehaviour
{
    public float alturaMinima;
    public float alturaMaxima;
    public float nroAlAzar;
    public Vector3 posicionInicial;
    public float limiteObstaculo;

    // Start is called before the first frame update
    void Start()
    {
        GenerarNroAlAzar();
        transform.position += Vector3.up * nroAlAzar;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < limiteObstaculo)
        {
            GenerarNroAlAzar();
            transform.position = posicionInicial + Vector3.up * nroAlAzar;
        }
    }

    void GenerarNroAlAzar()
    {
        nroAlAzar = Random.Range(alturaMinima, alturaMaxima);
    }
}
