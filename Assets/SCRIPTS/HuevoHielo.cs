using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuevoHielo : Item
{
    public override void Recoger()
    {
        score.PuntajeActual += 20;
        Debug.Log("El huevo de dragon, parece estar helado!, quizas es un dragon de hielo!");
        Destroy(gameObject);
    }
}
