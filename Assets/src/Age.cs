using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Age : MonoBehaviour
{

    private int ageInYears;
    private bool halfYear; 
    private float currentYearPosition;

    [SerializeField] private GameObject sun;
    private Vector3 sunTransformPosition;


    // Start is called before the first frame update
    void Start()
    {
        ageInYears = 0;
        currentYearPosition = 0f;
        halfYear = false;
        sun = GameObject.Find("SUN");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sunTransformPosition = sun.transform.position;
        Vector3 sunToPlanet = this.transform.position - sunTransformPosition;
        float theta = Vector3.Angle(Vector3.right, sunToPlanet);

        if (this.transform.position.y > 0)
        {
            Debug.Log(theta / 30);
            return;
        }
        Debug.Log(12 - (theta / 30));
    }
}
