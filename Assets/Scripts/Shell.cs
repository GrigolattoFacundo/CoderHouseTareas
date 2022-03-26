using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float speed;
    public float shellDamage;
    public float cannonCaliber = 0.88f;
    public float despawnTime;
    public float timeToDespawn;
    public Vector3 shellScale;
    private float currentSizeX;
    private float currentSizeY;
    private float currentSizeZ;
    private void Start()
    {
        currentSizeX = cannonCaliber;
        currentSizeY = cannonCaliber;
        currentSizeZ = cannonCaliber;
        despawnTime = 0;
        timeToDespawn = 15;
        shellDamage = (speed + cannonCaliber *100);
    }
    void Update()
    {
        despawnTime += Time.deltaTime;
        transform.position += transform.forward * speed * Time.deltaTime;
        if(despawnTime >= timeToDespawn)
        {
            DespawnShell();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentSizeX = currentSizeX *2;
            currentSizeY = currentSizeY *2;
            currentSizeZ = currentSizeZ *2;
            shellScale = new Vector3 (currentSizeX, currentSizeY, currentSizeZ);
            transform.localScale = shellScale;
        }
    }
     void DespawnShell()
    {
        //Destroy(gameObject, 5);
        //esto también funciona y reduce muchísimo la cantidad de líneas necesarias
        //pero como no necesita el timer no lo uso
       Destroy(this.gameObject);
    }
}
