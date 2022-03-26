using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4enemy1 : MonoBehaviour
{ 
    public Transform tiger;
    public GameObject turret;
    private float turretSpeed;

    private void Start()
    {
        turretSpeed = 1;
    }
    void Update()
    {
        Quaternion aim = Quaternion.LookRotation(tiger.transform.position - transform.position);
        turret.transform.rotation = Quaternion.Lerp(turret.transform.rotation, aim, turretSpeed * Time.deltaTime);
    }
}
