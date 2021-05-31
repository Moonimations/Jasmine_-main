using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadend : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);


        }

    }
  

}

