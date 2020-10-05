using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class InitalVelocity : MonoBehaviour
{
    private int _velocity;

    // when the button is pressed
    public void StartGame()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.velocity = (Vector3.down * _velocity);
        GameObject.Find("Start Button").GetComponent<Button>().interactable = false;
        GameObject.Find("Reset Button").GetComponent<Button>().interactable = true;
        GameObject.Find("Slider").GetComponent<EditDistanceFromSun>().enabled = false;
    }

    // when the text field is finished being updated
    public void UpdateInitialVelocity()
    {
        Text t = GameObject.Find("Velocity Input Box").GetComponent<Text>();
        _velocity = int.Parse(t.text);
    }
}
