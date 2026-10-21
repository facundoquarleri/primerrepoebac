using UnityEngine;

public class VariablesCharyString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //char c = '9';
        //int ValorEntero = (int)char.GetNumericValue(c)+5;
        //Debug.Log(ValorEntero);

        char miCaracter;
        string miString = "Hola soy Facundo";
        string miString2 = miString.Replace('o', 'O');
        string miString3 = miString + " " + miString2;

        miCaracter = miString[3];
        int longitud = miString.Length;
        string miNombre = "Facundo";
        string miApellido = "Quarleri";
        string miNombreCompleto = $"Mi nombre es {miNombre}\nMi apellido es Quarleri";

        Debug.Log(miNombreCompleto);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
