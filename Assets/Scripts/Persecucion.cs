using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persecucion : MonoBehaviour
{
    public float rangoAlerta;
    public LayerMask capaJugador;
    bool estarAlerta;
    public Transform jugador;
    public float veloci;

    void Start()
    {
        
    }

    
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position,rangoAlerta,capaJugador);
        if(estarAlerta)
        {
            transform.LookAt(new Vector3(jugador.position.x,transform.position.y,jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(jugador.position.x,transform.position.y,jugador.position.z),veloci*Time.deltaTime);
        }
    }
}
