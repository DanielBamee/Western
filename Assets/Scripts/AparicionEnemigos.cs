using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionEnemigos : MonoBehaviour
{
    public float[] enemigos;
    public int i = 0;
    public float tiempoEnemigos = 10;

    // Start is called before the first frame update
    private void Start()
    {
        enemigos = new float[10];
        for (float i = 0; i < 10; i++)
        {

        }
    }

    // Update is called once per frame
    private void Update()
    {
        for (float i = 0; i < 10; i++)
        {
            float randomValue = Random.Range(0, 2);
            if (randomValue == 0)
            {
                //enemigos[i].SetActive(true);
                tiempoEnemigos = tiempoEnemigos - Time.deltaTime;
            }
            //if enemigos[i] == (true)
            { 
                //enemigos[i].SetActive(true);
            }
                
        }
    }
}
