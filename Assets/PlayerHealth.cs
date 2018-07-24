using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int health;
    private int startingHealth;

    public GameObject gameOverPanel;
    public Text gameOverText;


    // Use this for initialization
    void Start () {
        startingHealth = health;
        gameOverPanel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (health > startingHealth)
        {
            health = startingHealth;
        }
        if (health <= 0)
        {
            
            gameOverPanel.SetActive(true);
            gameOverText.text = "You died... yikes :/";

            Time.timeScale = 0;
            Time.fixedDeltaTime = 0;
            //HELP ME

            //entity.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            //entity.GetComponent<ThirdPersonUserControl>().enabled = false;
        }
    }
}

