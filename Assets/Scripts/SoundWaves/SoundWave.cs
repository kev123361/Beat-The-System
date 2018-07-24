using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWave : MonoBehaviour { 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Interference Speaker")
        {
            collision.gameObject.GetComponent<SpeakerFire>().Fire();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            //knockback here
            collision.gameObject.GetComponent<EnemyHealth>().health -= 5;
            //can be multiplied by number of strings as the game progresses
        }

    
    }
}
