using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private const float Y = 0.5f;
    private const float X = 0.01f;
    private Vector3 healthBar;
    public Tiger t;

    private void Start()
    {
        t = FindObjectOfType<Tiger>();
       
    }

    private void Update()
    {
        Debug.Log("Health " + t.health);
        transform.localScale = healthBar;
        healthBar = new Vector3(X, Y, t.health / 100);
    }
}
