using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rock_detect : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;
    

    public bool onFloor = false;

    void Start()
    {

        onFloor = false;


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            onFloor = true;

        }

        else
        {

            onFloor = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onFloor = false;
    }


    // Update is called once per frame



}

