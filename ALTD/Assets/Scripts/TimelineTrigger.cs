using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public bool played = false;

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (!played)
            {
                played = true;
                timeline.Play();
            }
        }
    }
}
