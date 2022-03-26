using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4enemy3 : MonoBehaviour
{
    public GameObject tiger;
    public GameObject turret;
    private float turretSpeed;
    private float speed;
    private float distanceToPlayer;
    public EnemyBehaviour enemyBehaviour;
    public enum EnemyBehaviour
    {
        stay, follow
    }
    

    void Start()
    {
        turretSpeed = 1;
        speed = 3;
    }

    void Update()
    {

        switch (enemyBehaviour)
        {
            case EnemyBehaviour.stay:
                StayingEnemy();
                break;
            case EnemyBehaviour.follow:
                FollowingEnemy();
                break;
            default:
                Debug.LogWarning("That's not a programmed behaviour, try 'stay' or 'follow'");
                break;
                
        }
    }

    void StayingEnemy()
    {
        Quaternion aim = Quaternion.LookRotation(tiger.transform.position - transform.position);
        turret.transform.rotation = Quaternion.Lerp(turret.transform.rotation, aim, turretSpeed * Time.deltaTime);
    }

    void FollowingEnemy()
    {
        Quaternion aim = Quaternion.LookRotation(tiger.transform.position - transform.position);
        turret.transform.rotation = Quaternion.Lerp(turret.transform.rotation, aim, turretSpeed * Time.deltaTime);

        distanceToPlayer = Vector3.Distance(transform.position, tiger.transform.position);
        transform.position += transform.forward * speed * Time.deltaTime;
        Quaternion movement = Quaternion.LookRotation(tiger.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, movement, speed * Time.deltaTime);

        if (distanceToPlayer <= 10)
        {
            speed = 0;
        }
        //los assets que uso son demasiado grandes por ende 2m es muy poco,
        //terminan chocando antes de frenar; lo cambié por 10m
        else if (distanceToPlayer > 10)
        {
            speed = 3;
        }
    }
}
