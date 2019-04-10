using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraController : MonoBehaviour
{
    public GameObject player;
    public float minFov = 30f;
    public float maxFov = 130f;
    public float sensitivity = 0.0005f;

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

        //Set the camera to look at the player
        transform.LookAt(player.transform.position);
    }

    private void Update()
    {
        //Fov ajustment for using a mouse
       
        float fov = Camera.main.fieldOfView;
        float new_fov = fov;

        //If we are on a touchscreen device
        if (Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer)
        {
            //Implement pinch to ajust fov
            //If we have two touches on the screen
            if (Input.touchCount == 2)
            {
                // Store both touches.
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                // Find the position in the previous frame of each touch.
                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                // Find the magnitude of the vector (the distance) between the touches in each frame.
                float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

                // Find the difference in the distances between each frame.
                float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

                // Otherwise change the field of view based on the change in distance between the touches.
                new_fov += deltaMagnitudeDiff * sensitivity;
            }
        }

        else
        {
            //Use mouse for fov
            new_fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        }

        //Set the fov but check that it is of a sane value
        fov = Mathf.Clamp(new_fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;

    }

    private void RotateCam()
    {

    }
}
