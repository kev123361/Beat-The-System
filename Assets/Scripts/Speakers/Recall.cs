using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recall : MonoBehaviour {
    public Transform playerPos;

    public bool active = false;
    public bool active2 = false;
    public Vector3 rotationSpeed = new Vector3(0, 0, 90);
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
            if (!(active || active2))
            {
                StartCoroutine(ZoomToPlayer());
                active = true;
                rb.constraints = RigidbodyConstraints.None;
            }
        }
        if (active)
        {
            gameObject.transform.position =
                Vector3.LerpUnclamped(gameObject.transform.position, 
                gameObject.transform.position + new Vector3(0f, 5f, 0f), 1f * Time.deltaTime);
            transform.rotation = Quaternion.LerpUnclamped(transform.rotation, Quaternion.Euler(transform.eulerAngles + rotationSpeed), 3f * Time.deltaTime);
        }
        if (active2)
        {
            //gameObject.transform.position = 
            //    Vector3.LerpUnclamped(gameObject.transform.position, playerPos.position, 1f * Time.deltaTime);

            transform.LookAt(playerPos);
            rb.AddRelativeForce((Vector3.forward + new Vector3(0f, .2f, 0f)) * 20.0f, ForceMode.Acceleration);

            if (Vector3.Distance(gameObject.transform.position, playerPos.position) < 1f) {
                Destroy(gameObject);
            }
        }
	}

    IEnumerator ZoomToPlayer()
    {
        yield return new WaitForSecondsRealtime(.3f);
        active = false;
        active2 = true;
    }
}
