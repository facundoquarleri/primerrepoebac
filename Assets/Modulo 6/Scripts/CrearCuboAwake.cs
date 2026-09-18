using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class CrearCuboAwake : MonoBehaviour
{
    public GameObject prefabcubo;
    
    void Awake()
    {
        GameObject objToSpawn = Instantiate(prefabcubo);
        objToSpawn.name = "Crear cubo en Awake";
        objToSpawn.transform.position = Vector3.one;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
