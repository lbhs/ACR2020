using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCamera : MonoBehaviour
{
    private const float initialCameraViewAngle = 60; // RIGHT :)
    private const int zoomLerpSpeed = 10;
    private float targetZoom;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    public void ChangeCameraViewAngle(float zoomModifier)
    {
        //cam.orthographicSize = zoomModifier;
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, zoomModifier, Time.deltaTime * zoomLerpSpeed);
    }
}
