using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingProblem2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     string [] nombres ={"Laura","Carlos","Pablo","Junior","Emiliano","Luis","Ignacio","Paola"};
     string nombre = "Victor";
     if(lista(nombres,nombre)){
          Debug.Log("El alumno se encuentra inscrito");
     }
     else{
          Debug.Log("El alumno no se encuentra inscrito");
     }
    }

    bool lista(string[] nombres,string nombre){
        //bool x=null;
        for(int i=0; i<nombres.Length; i++)
            if(nombre == nombres[i]){
                Debug.Log("El alumno es :" +nombres[i]);
                return true;
            }
            return false;
    }

    
}
