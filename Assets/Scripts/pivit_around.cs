using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivit_around : MonoBehaviour
{
    public Transform target;
    public Transform pivit; 
    public Transform map;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        pivit.position = new Vector3(target.position.x, 0, target.position.z);
        map.position = new Vector3(-target.position.x, 0,-target.position.z);
        //target.position = Vector3.zero;

    }
}
