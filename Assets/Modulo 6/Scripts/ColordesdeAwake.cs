using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColordesdeAwake : MonoBehaviour

{
    private MeshRenderer miRenderer;
    private void Awake()
    {
        miRenderer = GetComponent<MeshRenderer>();
        Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        miRenderer.material.color = colorAleatorio;

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
    

