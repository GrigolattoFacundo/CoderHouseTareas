using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private const int Velocity = 1;
    private Vector3 ShellVelocity;
    
    void Update()
    {
        ShellVelocity += new Vector3(0, 0, Velocity);
    }
}
