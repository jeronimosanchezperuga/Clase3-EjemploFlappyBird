﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitToExecute : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instructions",2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instructions()
    {
        Debug.Log("Acá se ejecuta el código");
    }
}
