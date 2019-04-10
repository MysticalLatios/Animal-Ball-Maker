/* 
 * Authors : Seaney Shell,
 * GitHubs : RosyMapleMoth,
 * 
 * Last Modification : 04/07/2019
 * 
 * This file checks for players falling below the map.
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class playerScript : MonoBehaviour
{
    // HACk this is the lower game over bound, this should be grabbed from the level/map manger when one exists
    private int Level_LowerBound = -10;


    void Update()
    {
        // checks to see if player has fallen off the map
        if (transform.position.y <= Level_LowerBound)
        {
            // HACk When we have a script that manages switching levels we should use that rather then this
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
