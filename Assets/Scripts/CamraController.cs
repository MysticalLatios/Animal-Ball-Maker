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
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;



    }

    private void RotateCam()
    {

    }
}
