using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttachAge : MonoBehaviour
{ 
    public Text ageText;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(this.transform.position);
        pos.y += 2 * this.transform.localScale.y + 20f;
        ageText.transform.position = pos;
    }
}
