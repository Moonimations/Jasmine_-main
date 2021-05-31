using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class gravity2 : MonoBehaviour
{



    public static bool Test = false;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("Time for gravityy " + gameObject.name);
            Test = true;
          


}



        

        }


    

   
}