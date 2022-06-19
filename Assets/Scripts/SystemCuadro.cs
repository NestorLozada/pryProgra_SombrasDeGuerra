using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SystemCuadro : MonoBehaviour
{
    public bool estaEncendido=false;
    public GameObject imgtxt;
   public void cambio(){
       estaEncendido=!estaEncendido;
   }
   
   
    
    void Update()
    {
       if (estaEncendido){
        imgtxt.SetActive(false);
      
    }else{
        imgtxt.SetActive(true);
    }
    }
}
