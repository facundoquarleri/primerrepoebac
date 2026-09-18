using UnityEngine;

public class CreaCuboenUpdate : MonoBehaviour
{
    public GameObject prefabcubo;
    int contador = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador++;
        GameObject objToSpawn = Instantiate(prefabcubo);
        objToSpawn.name = "cubo numero" + contador;


    }
}
