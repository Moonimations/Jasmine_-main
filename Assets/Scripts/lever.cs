using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class lever : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject waterrad;
    public GameObject waterrad_moving;

    public GameObject fog;
    public AudioClip pull;

    public Camera camera;
    public Camera cutscene_camera;

   
    void Start()
    {
        waterrad_moving.SetActive(false);
        GetComponent<AudioSource>().playOnAwake = false;
         

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            

            GetComponent<AudioSource>().Play();

            waterrad.SetActive(false);
            waterrad_moving.SetActive(true);

            cutscene_camera.enabled = true; //or set active false if you dont wont the scripts on it running
            camera.enabled = false;
            
            StartCoroutine("WaitForSec");

        }

    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(8);

        waterrad_moving.SetActive(false);
        waterrad.SetActive(true);

        fog.SetActive(false);

        cutscene_camera.enabled = false; //or set active false if you dont wont the scripts on it running
        camera.enabled = true;
      
    }


}

