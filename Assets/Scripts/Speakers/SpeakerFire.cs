using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerFire : MonoBehaviour {
    public Rigidbody bullet;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Fire()

    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position + .5f * transform.forward, transform.rotation);
        bulletClone.velocity = transform.forward * 10f;

        Destroy(bulletClone.gameObject, 2);
    }
}
