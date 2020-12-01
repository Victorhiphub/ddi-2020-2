using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARinteraction : MonoBehaviour
{
    public AudioClip Sonido;
    public float Volumen = 1.5f;
    protected Transform Posicion = null;
    ///<sumary>
    ///OnMouseDown is called when te user has pressed the mouse button while
    /// over the GUIelement or collider
    /// <sumary>
    public void Start()
    {
        Posicion=transform;
    }
   void OnMouseDown()
   {
     AudioSource.PlayClipAtPoint(Sonido,Posicion.position,Volumen);
       Debug.Log("Comiendo....");
       Destroy(this.gameObject );
   }

  
}
