using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_prefab : MonoBehaviour
{

    public GameObject PlayePrefab;
    GameObject PlayerInstance;


    // Start is called before the first frame update
    void Start()
    {
        PlayerInstance = Instantiate(PlayePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        //Camera.main.transform.position = new Vector3(-3, 8, 0);
        Camera.main.GetComponent<CamraController>().player = PlayerInstance;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
