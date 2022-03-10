using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : MonoBehaviour
{
    Vector3 vectorTiger;
    public float speedX;
    public float speedY;
    public float speedZ;
    public Vector3 scale;
    public float health;
    private const int maxHealth = 1000;
    public int damageTaken;
    public int healingTaken;

    void Start()
    {
        health = maxHealth;
        damageTaken = 0;
        healingTaken = 0;

        vectorTiger = new Vector3(0, 1, 0);
        scale = new Vector3(1, 1, 1);
        speedX = 0;
        speedY = 0;
        speedZ = 0.05f;
    }

    void Update()
    {
        vectorTiger += new Vector3(speedX / 5, speedY / 5, speedZ / 5);
        transform.position = vectorTiger;
        transform.localScale = scale;
        health += healingTaken;
        health -= damageTaken;
        if (health <= 0)
        {
            health = 0;
            Debug.LogWarning("They blew you up or something idk yet");
        }
        if (health >= maxHealth)
        {
            health = maxHealth;
        }
        if (damageTaken < 0)
        { 
            damageTaken = 0;
        }
        if (healingTaken < 0) 
        {
            healingTaken = 0;
        }

        if(speedX > 0)
        {
            Debug.Log("Your current speed is " + speedX + " sideways to the right");
        }

        if (speedX < 0)
        {
            Debug.Log("Your current speed is " + speedX + " sideways to the left");
        }
        if (speedX == 0)
        {
            Debug.Log("You're not moving on X");
        }


        if (speedY > 0)
        {
            Debug.Log("Your current speed is " + speedY + " upwards");
        }

        if (speedY < 0)
        {
            Debug.Log("Your current speed is " + speedY + " downwards");
        }
        if (speedY == 0)
        {
            Debug.Log("You're not moving on Y");
        }
        
        
        if (speedZ > 0)
        {
            Debug.Log("Your current speed is " + speedZ + " frontwards");
        }

        if (speedZ < 0)
        {
            Debug.Log("Your current speed is " + speedZ + " backwards");
        }
        if (speedZ == 0)
        {
            Debug.Log("You're not moving on Z");
        }
    }

}
