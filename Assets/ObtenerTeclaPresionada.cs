using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerTeclaPresionada : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si se detecta CUALQUIER evento de la tecla A (presionada, mantenida o liberada)
        //Se ejecuta una vez por frame si se mantiene presionada
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Se ha detectado un evento de la tecla A");
        }

        //Si se detecta que la tecla ENTER fue PRESIONADA
        //Se ejecuta solamente una vez
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Se ha presionado la tecla Enter");
        }

        //Si se detecta que la tecla ESPACIO fue LIBERADA
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Se ha liberado la Barra Espaciadora");
        }
    }
}
