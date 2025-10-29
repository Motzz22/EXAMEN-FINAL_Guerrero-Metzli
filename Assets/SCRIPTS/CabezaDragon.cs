using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabezaDragon : Item
{
    public override void Recoger()
    {
        score.PuntajeActual += 20;
        Debug.Log("Increible! Encontraste un craneo de dragon! se dice que para que estos sean capaces de volar sus huesos deberian ser huecos como los de las aves!");
        Destroy(gameObject);
    }
}
