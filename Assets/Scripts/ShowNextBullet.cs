using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowNextBullet : MonoBehaviour
{
   public TextMeshProUGUI textoCambios;

    private void Update()
    {
        if (textoCambios != null)
        {
            textoCambios.Cambios.text = "Siguiente bala:" + GameManager.instance.CambiosDireccion;
        }
    
         
    
    }
}
