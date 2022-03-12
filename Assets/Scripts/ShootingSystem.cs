using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public GameObject shell;
    public Transform barrelPosition;
    private float time;
    private float shootTime;
    private bool clock = true;

    private void Start()
    {
        time = 0;
        shootTime = 0.1f;
    }
    private void Update(){Shoot();}
    
    
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shell, barrelPosition.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            for (int s = 0; s < 2; s++)
            {
                Instantiate(shell, barrelPosition.position, Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            for (int s = 0; s < 3; s++)
            {
                Instantiate(shell, barrelPosition.position, Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            for (int s = 0; s < 3; s++)
            {
                Instantiate(shell, barrelPosition.position, Quaternion.identity);
            }
        }
    }

}
