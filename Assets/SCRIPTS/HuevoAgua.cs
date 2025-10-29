using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuevoAgua : Item
{
    public override void Recoger()
    {
        score.PuntajeActual += 20;
        Debug.Log("El huevo de dragon, parece estar ¿humedo?, quizas es un dragon de Agua!");
        Destroy(gameObject);
    }
}
