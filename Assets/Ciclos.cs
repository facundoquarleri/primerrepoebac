using System.Runtime.InteropServices;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    //for => Sabemos cuantas veces vamos a repetir el ciclo
    //While => NO sabemos cuantas veces vamos a repetir el ciclo
    //do while => No sabemos cuantas veces vamos a repetir el ciclo pero sabemos que al menos una vez lo queremos ejecutar
    //arreglos Unidimensionales => [0, 1, 2, 3, 4]
    //arrgelo multidimensionales => [0,1 ,2]
    //                               [3, 4, 5]
    //                               [6, 7, 8]
    //                               
    //Arreglo jagged                
    //                              [0,1 ,2, 3, 4, 5]
    //                              [6, 7]
    //                              [8, 9, 10]
    //Foreach =>

    int contador = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] miArreglo = new int[5];
        string[] diasemanas = new string[7] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
        Debug.Log(diasemanas[0]);
        Debug.Log(diasemanas[1]);
        Debug.Log(diasemanas[2]);
        Debug.Log(diasemanas[3]);
        Debug.Log(diasemanas[4]);
        Debug.Log(diasemanas[5]);
        Debug.Log(diasemanas[6]);


        //for (int i = 0; i < diasemanas.Length; i++)
        //{
        //    Debug.Log(diasemanas[i]);

        //}
        foreach (int i in miArreglo)
        {
            Debug.Log(i);
        }
        foreach (string dia in diasemanas)
        {
            Debug.Log(dia);
        }
        //int[,] miMatriz = new int[3, 3] { {1,2,3 }, {4,5,6 }, {7,8,9 } };
        //for (int j = 0; j< miMatriz.GetLength(0); j++)
        //{
        //    for (int k = 0; k < miMatriz.GetLength(1); k++)
        //    {
        //        Debug.Log(miMatriz[j, k]);
        //    }

        //}
        //int[][] miArregloJagged = new int[][]
        //{
        //    new int[] { 1, 2, 3 },
        //    new int[] { 4,5 },
        //    new int[] { 6,7,8,9 }
        //};
        //miArregloJagged[1] = new int[] {10,11,12,13 };

        //bool MiBooleano = false;
        //while (MiBooleano) 
        //{
        //    contador++;
        //    Debug.Log("Hola");
        //}
        //do
        //{
        //    Debug.Log("Hola desde el do while");

        //} while (MiBooleano);
        // Update is called once per frame
        void Update()
        {
            contador++;
            Debug.Log(contador);
        }
    }

}
