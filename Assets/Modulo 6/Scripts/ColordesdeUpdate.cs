using UnityEngine;

public class ColordesdeUpdate : MonoBehaviour
{
    private MeshRenderer miRenderer;

    private void Awake()
    {
        miRenderer = GetComponent<MeshRenderer>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        miRenderer.material.color = colorAleatorio;

    }
}
 