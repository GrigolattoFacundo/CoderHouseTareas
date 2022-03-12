using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float speed;
    public Vector3 shellDirection;
    void Update() => Shoot();

    void Shoot()
    {
        transform.position += shellDirection * speed * Time.deltaTime; 
    }
}
