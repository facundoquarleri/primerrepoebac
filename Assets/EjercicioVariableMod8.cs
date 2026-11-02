using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioVariableMod8 : MonoBehaviour
{
    private MeshRenderer miRender;
    int VariableConsigna1 = 1;
    float VariablefloatConsigna1 = 1.5f;
    int Consigna3 = 0;
    public string ColorElegido = "rojo";






    private void Awake()
    {
        miRender = GetComponent<MeshRenderer>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //VariableEjercicio2();
        //float Decimal1 = 1.6f;
        //float Decimal2 = 1.7f;
        //int SumadeDecimales = (int)(Decimal1 + Decimal2);
        //Debug.Log("Consigna 2: " + SumadeDecimales);

        //float FloatEjercicio5 = 3.5255645f;
        //string FloatString = FloatEjercicio5.ToString("F4");
        //Debug.Log("Consigna 5: " + FloatString);


        //string Consigna6 = "Facundo Javier Quarleri Ferreyra";
        //string PrimerNombre = Consigna6.Substring(0, 7);
        //string SegundoNombre = Consigna6.Substring(8, 6);
        //string PrimerApellido = Consigna6.Substring(15, 8);
        //string SegundoApellido = Consigna6.Substring(23, 8);
        //string[] MiNombreList = Consigna6.Split(' ');
        //Debug.Log("Mi Primer nombre es: " + MiNombreList[0] + "\nMi Segundo nombre es: " + MiNombreList[1] + "\nMi Primer Apellido es: " + MiNombreList[2] + "\nMi Segundo Apellido es: " + MiNombreList[3]);

        //string n1 = "1564";
        //string n2 = "2456";
        //bool funciono1 = int.TryParse(n1, out int valor1);
        //bool funciono2 = int.TryParse(n2, out int valor2);


        //if (funciono1 && funciono2)
        //{
        //    int operacion1 = valor1 + valor2; 
        //    Debug.Log("Consigna1: " + operacion1);

        //}
        //else
        //{
        //    Debug.LogError("El valor no fue cargado correctamente");

        //}
        //string oracion = "Hola Mundo";
        //string resultado = "";


        //for (int i = 0; i < oracion.Length; i++)
        //{


        //    if (i %2 == 0)
        //    {
        //        resultado += oracion[i];
        //    }

        //}
        //Debug.Log("Consigna 2: " + resultado);
        //string palabrarandom = "botelladeagua";
        //string resuelto = palabrarandom.Remove(0, 5);
        //Debug.Log("Palabra: " +  palabrarandom);
        //Debug.Log("Palabra resuelta: " + resuelto);



    }

    // Update is called once per frame
    void Update()
    {
        VariableConsigna1++;
        //Debug.Log("int:" + VariableConsigna1);
        //switch (ColorElegido.ToLower().Trim())
        //{
        //    //case "rojo": miRender.material.color = Color.red;
        //    //    break;
        //    //case "azul": miRender.material.color = Color.blue;
        //    //    break;
        //    //case "amarillo": miRender.material.color = Color.yellow;
        //    //    break;
        //    //default:
        //    //    Debug.Log("El color no existe");
        //    //    break;

                
        //}


    }

    private void FixedUpdate()
    {
        //float AumentoFloat = VariablefloatConsigna1 *= 1.1f;
        //Debug.Log("Float: " + AumentoFloat);
        //Consigna3++;
        //int OperacionConsigna3 = Consigna3 % 2;
        //if (OperacionConsigna3 == 0)
        //{
        //    miRender.material.color = Color.white;

        //}
        //else
        //{
        //    miRender.material.color = Color.black;

        //}
        //Debug.Log("Consigna3: " + OperacionConsigna3);

    }
}
