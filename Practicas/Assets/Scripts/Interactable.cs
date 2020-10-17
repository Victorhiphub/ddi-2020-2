using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{   
    //int speed;
     bool isInsideZone =false;
    // Start is called before the first frame update
    public virtual void Interact()
    {
        Debug.Log("Interactuando....");
    }
    void Update()
    {
        if(isInsideZone && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = true;
    }
    void OnTriggerExit(Collider other)
    {
         if(!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = false;
    }
}
