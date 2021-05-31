using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class showUI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject fogbarrier;
    void Start()
    {
        fogbarrier.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            fogbarrier.SetActive(true);

            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        fogbarrier.SetActive(false);
    }
}

