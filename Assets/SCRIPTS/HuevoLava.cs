using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuevoLava : Item
{
    public override void Recoger()
    {
        score.PuntajeActual += 20;
        Debug.Log("Un huevo de dragon, parece ser calido, quizas es un dragon de lava!");
        Destroy(gameObject);
    }
}
