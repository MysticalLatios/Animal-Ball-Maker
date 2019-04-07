/* 
 * Authors : Seaney Shell,
 * GitHubs : RosyMapleMoth,
 * 
 * Last Modification : 04/07/2019
 * 
 * This file checks for players hitting goal and falling below the map, although most of these functions are in a HACK capicty here and would do 
 * better to be put in more apporate places when as they are created.
 */ 




using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Player_script : MonoBehaviour
{
    // HACk this is only used to display a Victory currently and should be removed when a game over UI is implamented
    private string GuiText = "";

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


    // Will end level and declayer victory, currently pausing scene, and displaying GUI text.
    private void TriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            // pause unity physics time cuasing the ball to stop
            Time.timeScale = 0;

            // TODO freeze player control as well so that the map can not be tilted



        }
    }

    private void OnGUI()
    {

    }



}
