using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float speed;
    public Vector3 shellDirection; 
    public float shellDamage;
    public float cannonCaliber = 0.88f;

    private void Start()
    {
        shellDamage = (speed + cannonCaliber);
    }
    void Update()
    {
        transform.position += shellDirection * speed * Time.deltaTime;
    }
}
