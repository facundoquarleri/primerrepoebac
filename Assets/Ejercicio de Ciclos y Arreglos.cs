using UnityEngine;

public class EjerciciodeCiclosyArreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ---------- Ejercicio 1 ----------
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int[] arr3 = new int[5];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Random.Range(1, 10);
            arr2[i] = Random.Range(1, 10);
            arr3[i] = arr1[i] + arr2[i];
        }

        for (int i = 0; i < arr3.Length; i++)
        {
            Debug.Log("Ej 1 - posicion " + i + ": " + arr1[i] + " + " + arr2[i] + " = " + arr3[i]);
        }

        // ---------- Ejercicio 2 ----------
        string[] palabras = new string[5];
        palabras[0] = "Ejercicio";
        palabras[1] = "De";
        palabras[2] = "Ciclos";
        palabras[3] = "Y";
        palabras[4] = "Arreglos";

        string oracion = "";
        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }
        oracion = oracion.Trim();

        Debug.Log("Ej 2: " + oracion);

        // ---------- Ejercicio 3 ----------
        int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] vector = new int[3] { 1, 2, 3 };
        int[] resultado = new int[matriz.GetLength(0)];

        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            int suma = 0;

            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                suma += matriz[fila, columna] * vector[columna];
            }

            resultado[fila] = suma;
        }

        for (int i = 0; i < resultado.Length; i++)
        {
            Debug.Log("Ej 3 - resultado[" + i + "] = " + resultado[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
