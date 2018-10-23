using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * USE SCRIPT ONLY FOR ENEMIES
 */

public class Health : MonoBehaviour {

    public float health;
    private float maxHealth = 100;
    public Image healthBarImage;

    public void OnEnable()
    {
        health = maxHealth;
    }

    // Starts Health on 100
    private void Start()
    {
        health = 100;
    }

    public event Action<float> onHealthPctChanged = delegate { };

    // Update is called once per frame
    void Update () {
        // Prints health on console
        Debug.Log(health);

        if(health <= 0)
        {
            Destroy(gameObject);
        }
	}

    /*
     * Basically, whenever the mud collides with whatever
     * object has this script, 50 health is removed from it.
     * 
     * So this script will go on enemies.
     */
    private void OnTriggerEnter(Collider other)
    {
        health = health - 50;
        float healthPCT = health / 100;
        healthBarImage.fillAmount = healthPCT;
    }
}
