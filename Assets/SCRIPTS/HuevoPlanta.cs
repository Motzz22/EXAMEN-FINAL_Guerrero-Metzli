using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuevoPlanta : Item
{
    public override void Recoger()
    {
        score.PuntajeActual += 20;
        Debug.Log("Un huevo de dragon, que curioso parece hecho de hojas, quizas es un dragon del bosque!");
        Destroy(gameObject);
    }
}
