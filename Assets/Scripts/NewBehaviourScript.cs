using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int kmPorDia = 90;
    int kmPorLitro = 15;
    int precioLitro = 130;

    public int cantidadDeUnidades;
    public int periodoDeDias;
    public int costoTotalCombustible;

    // Start is called before the first frame update
    void Start()
    {
        if ()
        {
            Debug.Log("Una flota de" + cantidadDeUnidades + "unidades trabajando durante" + periodoDeDias + "días implicará un gasto de" + costoTotalCombustible + "pesos en concepto de combustible");
        }
        
        if (costoTotalCombustible >= 13000)
        {
            precioLitro = 124;

            Debug.Log("hola");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
