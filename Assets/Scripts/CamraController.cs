using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraController : MonoBehaviour
{
    public GameObject player;
    public float minFov = 15f;
    public float maxFov = 90f;
    public float sensitivity = 10f;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame, after other objects have already been updated, sorta like at the end of a frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    private void Update()
    {
        //Fov ajustment for using a mouse
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;

        //Implement pinch to ajust fov
        //If we have two touches on the screen
        if (Input.touchCount >= 2)
        {
            Vector2 touch0, touch1;
            float distance;
            touch0 = Input.GetTouch(0).position;
            touch1 = Input.GetTouch(1).position;
            distance = Vector2.Distance(touch0, touch1);

            fov = Mathf.Clamp(distance, minFov, maxFov);
            Camera.main.fieldOfView = fov;
        }



    }

    private void RotateCam()
    {

    }
}
