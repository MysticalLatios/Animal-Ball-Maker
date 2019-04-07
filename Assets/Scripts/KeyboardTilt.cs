/* 
 * Authors : Seaney Shell,
 * GitHubs : RosyMapleMoth,
 * 
 * Last Modification : 04/07/2019
 * 
 * a file that interduces testing tools tilting the map.
 * TODO Make the affected transform be a vairable that is passed in rather then just the attached transform.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTilt : MonoBehaviour
{

    /* This code snipit is a very lightly modified version of the code found at 
     * https://github.com/snailface/UnityBasics/wiki/Rotating-an-Object-through-Arrow-Keys
     * Author : hasala-snailface
     */
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -1f);
        }
    }

}
