using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public float tiempo ;
    public float segundos = 60f;
    public GameObject cajaDeTiempo;
    public TextMeshProUGUI textoTiempo;
    public GameObject panelInicio;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
            tiempo = tiempo - Time.deltaTime;
            textoTiempo.text = tiempo.ToString();
    }
}
