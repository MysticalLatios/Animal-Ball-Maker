using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * To use this your map must be in the structure of with all ->'s meaning "parent of"
 * GameObject pivit -> GameObject map -> all objects to be rotated by user input.   
 * 
 * Note : this can cuase some issues on highly vertical maps and when the ball gets a large distance away from the map, 
 *        so Stoping exacution quickly after a level fails or ball leaves the bounds may be a good idea
 * 
 * 
 */

public class pivit_around : MonoBehaviour
{



    public Transform target; // set this to the player's transform
    public Transform pivit;  // set this to the top level pivit objects transform
    public Transform map; // set this to the map objects transform 
    public bool active;



    // this insures the world will pivit around the player
    private void FixedUpdate()
    {
        pivit.position = new Vector3(target.position.x, 0, target.position.z);
        map.position = new Vector3(0, 0, 0);
    }

}
