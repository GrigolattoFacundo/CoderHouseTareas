using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float speed;
    public Vector3 shellDirection; 
    public float shellDamage;
    public float cannonCaliber = 0.88f;
    public float despawnTime;
    private float timeWhenShoot;

    private void Start()
    {
        despawnTime = 0;
        timeWhenShoot = 10;
        shellDamage = (speed + cannonCaliber *100);
    }
    void Update()
    {
        despawnTime += Time.deltaTime;
        transform.position += shellDirection * speed * Time.deltaTime;
        if(despawnTime >= timeWhenShoot)
        {
            DespawnShell();
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
