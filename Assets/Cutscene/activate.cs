using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class activate : MonoBehaviour
{
    public GameObject waterrad_moving;

    public PlayableDirector timeline;

    // Start is called before the first frame update
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waterrad_moving.activeInHierarchy == true)
        {
            timeline.Play();


        }


    }
}
