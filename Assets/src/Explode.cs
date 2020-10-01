using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Transform t = this.transform;
        Destroy(this);
    }
}
