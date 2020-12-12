using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : VoiceInteractable
{

  
  

   

    public override void VoiceInteract(string action)
       {
        if(action=="work")
        {
        GetComponent<AudioSource>().Play();
        }
        
       }
      
       
        
    }
