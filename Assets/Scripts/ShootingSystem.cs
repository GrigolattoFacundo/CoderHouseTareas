using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public GameObject shell;
    public Transform barrelPosition;
    public float timer;
    public float shootTiming;

    private void Start()
    {
        timer = 0;
        shootTiming = 3;
    }

    private void Update()
    {
        Shoot();
        timer += Time.deltaTime;
    }
   
    
    void Shoot()
    {
        if (shootTiming <= timer)
        {
            Instantiate(shell, barrelPosition.position, Quaternion.identity);
            timer = 0;
        }
        
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
            for (int s = 0; s < 4; s++)
            {
                Instantiate(shell, barrelPosition.position, Quaternion.identity);
            }
        }
    }

}
