using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour {

    public float knockbackForce;
    public Rigidbody entity;


    private void OnCollisionEnter(Collision collision)
    {
        if (entity.gameObject.tag == "Player" && collision.gameObject.tag == "Enemy")
        {
            Vector3 hitDirection = collision.transform.position - entity.transform.position;
            hitDirection = hitDirection.normalized;
            //collision.contacts[0].point;
            hitDirection.y = -0.25f;
            Knock(-hitDirection);
        }
    }

    public void Knock(Vector3 direction)
    {
        entity.AddForce(direction * knockbackForce, ForceMode.Impulse);
        entity.gameObject.GetComponent<PlayerHealth>().health -= 5;
        //health lost depends on the strength of the enemy but it's just 5 for now
        //add cooldown so that it can't get hit twice in a row
    }
}
