/* 
 * Authors : Seaney Shell,
 * GitHubs : RosyMapleMoth,
 * 
 * Last Modification : 04/07/2019
 * 
 * This file creates a player at the position of the attached GameObject at Start()
 * TODO this functionality should be moved to a gameManger of some kind when created.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_prefab : MonoBehaviour
{
    public GameObject PlayePrefab;
    public pivit_around pivit;
    GameObject PlayerInstance;

    void Awake()
    {
        // create player instance
        PlayerInstance = Instantiate(PlayePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        PlayerInstance.SetActive(false);


        // sets the link to player in the pivit controller
        pivit.target = PlayerInstance.transform;

        // insure camraController knows about player instance.
        Camera.main.GetComponent<CamraController>().player = PlayerInstance;
    }


    // Start is called before the first frame update
    void Start()
    {
        PlayerInstance.SetActive(true);
    }

}
