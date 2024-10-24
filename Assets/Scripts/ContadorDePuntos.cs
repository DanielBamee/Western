using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorDePuntos : MonoBehaviour
{
    public float contadorPuntos = 0;
    public TextMeshProUGUI textoContadorPts;
    public TextMeshProUGUI textoContadorPtsGanados;
    public bool enemigos = false;
    public float tempoEnemigos1 = 0;
    public float tempoEnemigos2 = 0;
    public float tempoEnemigos3 = 0;
    public float tempoEnemigos4 = 0;
    public float tempoEnemigos5 = 0;
    public float tempoVivos1 = 0;
    public float tempoVivos2 = 0;
    public float tempoVivos3 = 0;
    public float tempoVivos4 = 0;
    public float tempoVivos5 = 0;
    public GameObject chicoMalo1;
    public GameObject chicoMalo2;
    public GameObject chicoBueno;
    public GameObject señorita;
    public GameObject sheriff;

    public bool enPartida;
    public GameObject canvasStart;
    public GameObject canvasFinal;
    // Start is called before the first frame update
    void Start()
    {
        //ya que no sabia usar muy bien los arrays, lo hice pero version gomera, mas a lo bruto... MUY a lo bruto
        if (enemigos == false)
        {
            chicoMalo1.SetActive(false);
            chicoMalo2.SetActive(false);
            chicoBueno.SetActive(false);
            señorita.SetActive(false);
            sheriff.SetActive(false);
        }      
    }

    // Update is called once per frame
    void Update()
    {
        textoContadorPts.text = contadorPuntos.ToString();
        textoContadorPtsGanados.text = contadorPuntos.ToString();

        if (enPartida == true)
        {
            tempoEnemigos1 = tempoEnemigos1 + Time.deltaTime;
            tempoEnemigos2 = tempoEnemigos2 + Time.deltaTime;
            tempoEnemigos3 = tempoEnemigos3 + Time.deltaTime;
            tempoEnemigos4 = tempoEnemigos4 + Time.deltaTime;
            tempoEnemigos5 = tempoEnemigos5 + Time.deltaTime;
        }
        

        if (tempoEnemigos1 >= 5)
        {
            chicoMalo1.SetActive(true);
            tempoVivos1 = tempoVivos1 + Time.deltaTime;
            if (tempoVivos1 >= 5)
            {
                chicoMalo1.SetActive(false);
                if (tempoVivos1 > 5)
                {
                    tempoVivos1 = 0;
                    tempoEnemigos1 = 0;
                }
            }
        }
        if (tempoEnemigos2 >= 3)
        {
            chicoMalo2.SetActive(true);
            tempoVivos2 = tempoVivos2 + Time.deltaTime;
            if (tempoVivos2 >= 3)
            {
                chicoMalo2.SetActive(false);
                if (tempoVivos2 > 3)
                {
                    tempoVivos2 = 0;
                    tempoEnemigos2 = 0;
                }
            }
        }
        if (tempoEnemigos3 >= 4)
        {
            chicoBueno.SetActive(true);
            tempoVivos3 = tempoVivos3 + Time.deltaTime;
            if (tempoVivos3 >= 4)
            {
                chicoBueno.SetActive(false);
                if (tempoVivos3 > 4)
                {
                    tempoVivos3 = 0;
                    tempoEnemigos3 = 0;
                }
            }
        }
        if (tempoEnemigos4 >= 8)
        {
            señorita.SetActive(true);
            tempoVivos4 = tempoVivos4 + Time.deltaTime;
            if (tempoVivos4 >= 8)
            {
                señorita.SetActive(false);
                if (tempoVivos4 > 8)
                {
                    tempoVivos4 = 0;
                    tempoEnemigos4 = 0;
                }
            }
        }
        if (tempoEnemigos5 >= 10)
        {
            sheriff.SetActive(true);
            tempoVivos5 = tempoVivos5 + Time.deltaTime;
            if (tempoVivos5 >= 10)
            {
                sheriff.SetActive(false);
                if (tempoVivos5 > 10)
                {
                    tempoVivos5 = 0;
                    tempoEnemigos5 = 0;
                }
            }          
        }
    }

    public void EnemigoMalo1()
    {
        contadorPuntos = contadorPuntos + 500f;
        chicoMalo1.SetActive(false);
    }
    public void EnemigoMalo2()
    {
        contadorPuntos = contadorPuntos + 750f;
        chicoMalo2.SetActive(false);
    }
    public void BuenHombre1()
    {
        contadorPuntos = contadorPuntos - 50f;
        chicoBueno.SetActive(false);
    }
    public void Señorita()
    {
        contadorPuntos = contadorPuntos - 80f;
        señorita.SetActive(false);
    }
    public void Sheriff()
    {
        contadorPuntos = contadorPuntos - 100f;
        sheriff.SetActive(false);
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
