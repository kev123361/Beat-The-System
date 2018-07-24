using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Keeps track of currently selected speakers. References to individual speaker prefabs should go here.
public class ActiveSpeaker : MonoBehaviour {
    public Rigidbody currSpeaker;

    public Rigidbody auxSpeaker;
    public Rigidbody interSpeaker;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public Rigidbody getSpeaker()
    {
        return currSpeaker;
    }

    public void SetSpeaker(GameObject newSpeaker)
    {
        // Debug.Log(newSpeaker);
        currSpeaker = newSpeaker.GetComponent<Rigidbody>();
    }
}
