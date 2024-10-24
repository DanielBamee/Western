using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RetryCanvas : MonoBehaviour
{
    [SerializeField]
    public GameObject canvasStart;
    [SerializeField]
    public float tiempo;

    public GameObject cajaDeTiempo;
    public TextMeshProUGUI textoTiempo;
    public bool enPartida = false;

    [SerializeField]
    public GameObject canvasFinal;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (enPartida == true)
        {
            tiempo = tiempo - Time.deltaTime;
            textoTiempo.text = ((int)tiempo).ToString();
            //Debug.Log("Está Activado");

            if (tiempo <= 0)
            {
                canvasFinal.SetActive(true);
                enPartida = false;
                tiempo = 60;
            }
        }
    }

    public void SeActivaElBoton()
    {
        enPartida = true;
        canvasStart.SetActive(false);
        Debug.Log("Le has dado");
    }
    public void SeActivaElBotonRetry()
    {
        enPartida = true;
        canvasFinal.SetActive(false);
        Debug.Log("Le has dado2");
    }
}
