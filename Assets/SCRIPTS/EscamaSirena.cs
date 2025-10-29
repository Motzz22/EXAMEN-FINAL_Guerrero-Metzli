using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscamaSirena : Item
{
    public override void Recoger()
    {
        score.PuntajeActual++;
        Debug.Log("Encontraste la escama de una sirena. Las sirenas son creaturas mitad mujer de las caderas hacia arriba y mitad pez de las caderas hacia abajo, se dice que poseen una belleza increible capaz de tentar a los hombres al agua con solo su canto para despues ahogarlos, en la antiguedad los marinos decian que si un sirena te daba un beso esta te otorgaria la habilidad de respirar bajo el agua.");
        Destroy(gameObject);
    }
}

   
  
