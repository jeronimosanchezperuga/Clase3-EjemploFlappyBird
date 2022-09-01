using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectarColisiones : MonoBehaviour
{
    public Text txtPuntaje;
    public int puntaje;
    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;

    }

    // Update is called once per frame
    void Update()
    {
        txtPuntaje.text = puntaje.ToString();
    }

    void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D()
    {
        puntaje++;
    }
    
}
