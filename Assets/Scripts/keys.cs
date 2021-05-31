using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class keys : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip collect;

    public GameObject key;
    public GameObject key_pickup;

    void Start()
    {
        key.SetActive(true);
        key_pickup.SetActive(false);
        GetComponent<AudioSource>().playOnAwake = false;
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            
            StartCoroutine("WaitForSec");
            GetComponent<AudioSource>().Play();
        }

    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        
        key.SetActive(false);
        key_pickup.SetActive(true);

    }


}

