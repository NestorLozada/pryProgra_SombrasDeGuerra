using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
   public Image imagenVida;

    public float vidaActual=100;

    public float vidaMaxima=100;
    
    void Update()
    {
        if(vidaActual > 50)
        {
            vidaActual = vidaActual - 1;
        }
        imagenVida.fillAmount = vidaActual /vidaMaxima;
    }
}
