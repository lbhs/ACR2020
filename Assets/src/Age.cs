using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Age : MonoBehaviour
{
    private int ageInYears; 
    private float currentYearPosition;
    private bool halfYear = false;
    public Text ageText;

    [SerializeField] private GameObject sun;
    private Vector3 sunTransformPosition;


    // Start is called before the first frame update
    void Start()
    {
        ageInYears = 0;
        currentYearPosition = 0f;
        sun = GameObject.Find("SUN");
        ageText = GameObject.Find("Age Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // find an angle `theta` between the planet and the x-axis...
        sunTransformPosition = sun.transform.position;
        Vector3 sunToPlanet = this.transform.position - sunTransformPosition;
        float theta = Vector3.Angle(Vector3.right, sunToPlanet);

        // find the current "position" in the year (month) using `theta`
        if (this.transform.position.y > sun.transform.position.y)
        {
            currentYearPosition = theta / 30;
        }
        else
        {
            currentYearPosition = 12 - (theta / 30);
        }

        // marks the halfway point in the orbit
        if (Mathf.Abs(currentYearPosition - 6f) < .1)
        {
            halfYear = true;
        }
        // increments the age in years value by 1 per orbit
        else if (halfYear && Mathf.Abs(currentYearPosition - 12f) < .01)
        {
            ageInYears++;
            halfYear = false;
        }

        //Debug.Log("Age: " + ageInYears + " years, " + Mathf.Floor(currentYearPosition) + " months.");
        ageText.text = "Age: " + ageInYears + " years, " + Mathf.Floor(currentYearPosition) + " months.";
    }
}
