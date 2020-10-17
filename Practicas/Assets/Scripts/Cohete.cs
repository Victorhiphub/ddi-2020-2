using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cohete : Interactable 
{
    Rigidbody rb;
    public float KickForce = 50f;
    public AudioClip Sonido = null;
    public float Volumen = 1.5f;
    protected Transform Posicion = null;

    public Vector3 KickDirection;
    public void Start()
    {
        Posicion=transform;
    }
    void Awake()
    {
        
        rb=GetComponent<Rigidbody>();
    }
    public override void Interact()
    {
        base.Interact();
        if(rb != null)
        {
            Debug.Log("A volar");
            rb.AddForce(KickDirection*KickForce,ForceMode.Force);
            AudioSource.PlayClipAtPoint(Sonido,Posicion.position,Volumen);
        }
    }
}
