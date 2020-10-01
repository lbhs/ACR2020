using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditObjectProperties : MonoBehaviour
{
    [SerializeField] private float massMargin;

    private void Start()
    {
        float m = this.GetComponent<Rigidbody>().mass;

        float sqrtM = Mathf.Sqrt(m);
        this.transform.localScale = new Vector3(sqrtM, sqrtM, sqrtM); // <-- changes scale of an object to the Vector3
    }

    public void IncreaseMass()
    {
        this.GetComponent<Rigidbody>().mass += massMargin;
    }

    public void DecreaseMass()
    {
        this.GetComponent<Rigidbody>().mass -= massMargin;
    }

    // can be cleaned up
    public void GravitySwitch()
    {
        Gravity g = this.GetComponent<Gravity>();
        g.enabled = !g.enabled;
    }

    public void MovementState()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.isKinematic = !rb.isKinematic;
    }

    public void SunMass()
    {
        Text t = GameObject.Find("SunText").GetComponent<Text>(); // finds the "SunText" object and assigns the text component to `t`
        int m = int.Parse(t.text); // turns the text from `t` into

        this.GetComponent<Rigidbody>().mass = m;

        float sqrtM = Mathf.Sqrt(m);
        this.transform.localScale = new Vector3(sqrtM, sqrtM, sqrtM); // <-- changes scale of an object to the Vector3
    }

    public void EarthMass()
    {
        Text t = GameObject.Find("EarthText").GetComponent<Text>(); // finds the "SunText" object and assigns the text component to `t`
        int m = int.Parse(t.text); // turns the text from `t` into

        this.GetComponent<Rigidbody>().mass = m;

        float sqrtM = Mathf.Sqrt(m);
        this.transform.localScale = new Vector3(sqrtM, sqrtM, sqrtM); // <-- changes scale of an object to the Vector3
    }

}
