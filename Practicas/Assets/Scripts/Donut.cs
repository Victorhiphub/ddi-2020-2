using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nueva Comida", menuName = "Inventario/Food/Chocolate")]
public class Donut : Item
{
    public float recuperacion = 0.9f;

    public int chocolateTiles =10;

    public override void Use()
    {
        Debug.Log("Consumiento Dona...se ah recuperado un " + recuperacion + "% De cordura");
    }

}
