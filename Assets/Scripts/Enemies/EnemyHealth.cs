using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    public int health;
    private int startingHealth;
    public Rigidbody collectible;

	// Use this for initialization
	void Start () {
        startingHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
        if (health > startingHealth)
        {
            health = startingHealth;
        }
		if (health <= 0)
        {
               Vector3 dropLocation = transform.position;
               Quaternion dropRotation = transform.rotation;
               Destroy(gameObject);
               Instantiate(collectible, dropLocation, dropRotation);         
        }
	}
}
