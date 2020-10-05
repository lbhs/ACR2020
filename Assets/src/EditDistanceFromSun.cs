using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditDistanceFromSun : MonoBehaviour
{
    public Slider distanceSlider;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject.Find("Earth").GetComponent<Rigidbody>().transform.position = new Vector3(-distanceSlider.value, 0, 0);
    }

}
