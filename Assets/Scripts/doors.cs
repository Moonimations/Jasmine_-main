using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class doors : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;
    public GameObject key;
    public AudioClip shine;
    public GameObject key_pickup;

    void Start()
    {
        door.SetActive(true);
        GetComponent<AudioSource>().playOnAwake = false;

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            if (key.activeSelf)
            {

                door.SetActive(true);
                }
            else
            {
                GetComponent<AudioSource>().Play();
                key_pickup.SetActive(false);
                StartCoroutine("WaitForSec");


            }



        }

    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        door.SetActive(false);
    }


}

