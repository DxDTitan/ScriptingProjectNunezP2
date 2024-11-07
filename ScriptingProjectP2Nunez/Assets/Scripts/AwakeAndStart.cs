using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
   
    void Awake ()
    {
        Debug.Log("Awake called.");
    }

    
    void Update()
    {
        Debug.Log("Start called.");
    }
}
