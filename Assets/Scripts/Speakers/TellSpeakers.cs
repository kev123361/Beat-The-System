using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TellSpeakers : MonoBehaviour {
    private ActiveSpeaker currSpeaker;
    
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        currSpeaker = GetComponent<ActiveSpeaker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            TellSpeakersToFire();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlaceSpeaker();
        }
    }

    private void PlaceSpeaker()
    {
        
        Rigidbody newSpeaker = (Rigidbody)Instantiate(currSpeaker.getSpeaker(), 
            player.transform.position + (player.transform.forward) + new Vector3(0f, 1f, 0f), player.transform.rotation);

        newSpeaker.transform.parent = transform;
    }

    public void TellSpeakersToFire()
    {
        ParticleSystem[] speakers = GetComponentsInChildren<ParticleSystem>();

        for (int i = 0; i < speakers.Length; i++)
        {
            if (speakers[i].tag == "Auxiliary Speaker")
            {
                speakers[i].Play();
            }
        }
    }
}
