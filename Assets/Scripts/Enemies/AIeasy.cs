using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIeasy : MonoBehaviour {

    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform fpsTarget;
    Rigidbody thergb;
    Renderer myRender;


	// Use this for initialization
	void Start () {
        myRender = GetComponent<Renderer>();
        thergb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
        if( fpsTargetDistance < enemyLookDistance)
        {
            myRender.material.color = Color.red;
            lookAtPlayer();
        }
        if(fpsTargetDistance < attackDistance)
        {
            attackPles();
        }
        else
        {
            myRender.material.color = Color.blue;
        }
	}


    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }
    void attackPles()
    {
        thergb.AddForce(transform.forward * enemyMovementSpeed);
    }
}
