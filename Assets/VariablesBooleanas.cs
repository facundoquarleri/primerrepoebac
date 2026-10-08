using UnityEngine;
using UnityEngine.Rendering;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteinferior = 0;
    int limitesuperior = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;

        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La operacion 1 es verdadera");

            if ((variable1 || variable2) || variable3)
                if (variable1)
                {
                    Debug.Log("La variable 1 es verdadera");
                }
            Debug.Log("La operacion 2 es verdadera");

        }
        if ((variable1 && variable2) || variable3)
        {
            Debug.Log("La operacion 3 es verdadera");

        }

        valor1 = Random.Range(limiteinferior, limitesuperior);
        Debug.Log(valor1);
        //if (valor1 >= 0)
        //{
        //    Debug.Log("El valor es positivo");

        //}
        //else
        //{
        //    Debug.Log("El valor es negativo");

        //}
        string resultado = (valor1>=0) ? "El valor es positivo" : "El valor es negativo";



        //switch (valor1)
        //{
        //    case (int)SeleccionColor.rojo:
        //Debug.Log("El color seleccionado es Rojo");
        //break;
        //    case (int)SeleccionColor.verde:
        //Debug.Log("El color seleccionado es Verde");
        //break;
        //    case (int)SeleccionColor.azul:
        //Debug.Log("El color seleccionado es Azul");
        //break;
        //    case (int)SeleccionColor.blanco:
        //Debug.Log("El color seleccionado es Blanco");
        //break;
        //    case (int)SeleccionColor.gris:
        //Debug.Log("El color seleccionado es Gris");
        //break;
        //default:
        //Debug.Log("Ese valor no existe");
        //break;


    }


}

// Update is called once per frame
//void Update()
//
//}
//}
