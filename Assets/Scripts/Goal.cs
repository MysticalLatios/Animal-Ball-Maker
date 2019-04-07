/* 
 * Authors : Seaney Shell,
 * GitHubs : RosyMapleMoth,
 * 
 * Last Modification : 04/07/2019
 * 
 * Freezes game if you hit goal, and prints to "hit goal Victory!!" to log
 *  TODO print text to screen.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{


    // Will end level and declayer victory, currently pausing scene, and displaying GUI text.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit goal Victory!!");
            // pause unity physics time cuasing the ball to stop
            Time.timeScale = 0;

            // HACK this is where we would go to the next level or a menu if such feture was implamented.

        }
    }
}
