using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleUI : MonoBehaviour
{
    public GameObject Canvas;
    public Boolean B = false;

    public void Toggle()
    {
        Canvas.SetActive(B);
        if (B == false) 
        { 
            B = true; 
        }
        else { B = false; }
           
    }
}
