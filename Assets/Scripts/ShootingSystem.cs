using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public GameObject shell;

    void Shoot(Vector3 CannonPosition)
    {
        Instantiate(shell, CannonPosition, Quaternion.identity);
    } 
}