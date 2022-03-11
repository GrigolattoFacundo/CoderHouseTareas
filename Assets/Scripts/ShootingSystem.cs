using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public GameObject shell;
    public Transform barrelPosition;

    private void Update() => Shoot();
    
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shell, barrelPosition.position, Quaternion.identity);
        }
    }

}