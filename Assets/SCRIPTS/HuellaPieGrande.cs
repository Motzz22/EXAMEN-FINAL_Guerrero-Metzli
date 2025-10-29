using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuellaPieGrande : Item
{
    public override void Recoger()
    {
        score.PuntajeActual ++;
        Debug.Log("Encontraste la huellas de pie grande, se cree que mide alrededor de 2.23m con un peso de 160 kg, el primer avistamiento confirmado fue en 1985 en el condado de HUmbolt");
        Destroy(gameObject);
    }
}