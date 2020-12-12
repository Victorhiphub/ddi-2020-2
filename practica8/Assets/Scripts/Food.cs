using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : VoiceInteractable
{

  
  

   

    public override void VoiceInteract(string action)
       {
          
        if(action=="hello")
        {
        Destroy(gameObject);
        }
       

       }
      
       
        
    }