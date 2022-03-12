using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private const float Y = 0.5f;
    private const float X = 0.01f;
    private Vector3 healthBar;
    public Tiger t;

    private void Start()
    {
        t = FindObjectOfType<Tiger>();
       
    }

    private void Update()
    {
        Debug.Log("Health " + t.health);
        transform.localScale = healthBar;
        healthBar = new Vector3(X, Y, t.health / 100);
    }

/*public class ObjectSpawner : MonoBehaviour
{
    // Tiempo en segundos
    private float tiempoParaAccion = 3;
    private float tiempoActual = 0;

    private int printeosQueQuedan = 3;

    private bool relojCorriendo = true;

    private void Update()
    {
        if (relojCorriendo)
        {
            tiempoActual += Time.deltaTime;

            if (tiempoActual >= tiempoParaAccion)
            {
                if (printeosQueQuedan > 0)
                {
                    tiempoActual = 0;
                    Debug.Log("Hola como estas loco");
                    printeosQueQuedan--;
                }
                else
                {
                    relojCorriendo = false;
                }
            }
        }
    }*/
}