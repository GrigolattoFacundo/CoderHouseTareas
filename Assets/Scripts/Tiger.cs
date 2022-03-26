using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : MonoBehaviour
{
    Vector3 vectorTiger;
    public float health;
    private const int maxHealth = 1000;
    public int damageTaken;
    public int healingTaken;
    public float speed;
    public float rotation;
    void Start()
    {
        health = maxHealth;
        damageTaken = 0;
        healingTaken = 0;
        speed = 10;
        vectorTiger = new Vector3(0, 1, 0);
    }

    void Update()
    {
        DrivingSystem();
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
    }
    void DrivingSystem()
    {
       
        transform.position += transform.forward * speed * Input.GetAxisRaw("Vertical") * Time.deltaTime;

        rotation = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, (rotation * 100), 0);
    }
}
