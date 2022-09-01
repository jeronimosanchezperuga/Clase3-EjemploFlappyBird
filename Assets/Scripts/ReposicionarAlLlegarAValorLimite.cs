using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReposicionarAlLlegarAValorLimite : MonoBehaviour
{
    public Vector3 posicionInicial;
    public float valorLimite;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= valorLimite)
        {
            transform.position = posicionInicial;
        }
    }
}
