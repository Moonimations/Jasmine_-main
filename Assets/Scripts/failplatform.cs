using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failplatform : MonoBehaviour
{

   

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("Anddd gravity gone " + gameObject.name);

            gravity2.Test = false;
            

        }


    }
   
}
