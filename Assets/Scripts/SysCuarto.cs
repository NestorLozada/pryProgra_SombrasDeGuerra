using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SysCuadro : MonoBehaviour
{
    public bool estaEncendido=true;
    public GameObject imgtxt;
   public void cambio(){
       estaEncendido=!estaEncendido;
   }
   
   
    
    void Update()
    {
       if (estaEncendido){
        imgtxt.SetActive(true);
      
    }else{
        imgtxt.SetActive(false);
    }
    }
}

