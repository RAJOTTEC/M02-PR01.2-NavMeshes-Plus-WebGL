using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;

    void Start()
    {
        if(gameObject.tag == "Spider")
        {
            maxHealth = 1;
        }

        if(gameObject.tag == "Humanoid")
        {
            maxHealth = 2;
        }

        if(gameObject.tag == "Ogre")
        {
            maxHealth = 3;
        }
        health = maxHealth;
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            if(gameObject.tag == "Spider")
            {
                Debug.Log("Spider death");
            }

            if (gameObject.tag == "Humanoid")
            {
                Debug.Log("Humanoid death");
            }

            if (gameObject.tag == "Ogre")
            {
                Debug.Log("Ogre death");
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(gameObject.tag == "Spider")
        {
            if (other.gameObject.tag == "Humanoid")
            {
                health -= Time.deltaTime * 5;
            }

            if (other.gameObject.tag == "Ogre")
            {
                health -= Time.deltaTime * 2.5f;
            }
        }

        if (gameObject.tag == "Humanoid")
        {
            if (other.gameObject.tag == "Ogre")
            {
                health -= Time.deltaTime * 5;
            }

            if (other.gameObject.tag == "Spider")
            {
                health -= Time.deltaTime * 2.5f;
            }
        }

        if (gameObject.tag == "Ogre")
        {
            if (other.gameObject.tag == "Spider")
            {
                health -= Time.deltaTime * 5;
            }

            if (other.gameObject.tag == "Humanoid")
            {
                health -= Time.deltaTime * 2.5f;
            }
        }
        
    }
}
