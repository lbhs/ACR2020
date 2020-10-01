using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalGravity : MonoBehaviour
{

    private GameObject[] gos;
    // Start is called before the first frame update
    void Start()
    {
        gos = GameObject.FindGameObjectsWithTag("test");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (GameObject g in gos)
        {

        }
    }
}
