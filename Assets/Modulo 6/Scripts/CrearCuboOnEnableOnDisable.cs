using UnityEngine;


public class CrearCuboOnEnableOnDisable : MonoBehaviour
{
    public GameObject prefabcubo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        GameObject objToSpawn = Instantiate(prefabcubo);
        objToSpawn.name = "cubo creado OnEnable";
        objToSpawn.transform.position = new Vector3(-2, 0, 0);
        objToSpawn.GetComponent<MeshRenderer>().material.color = Color.green;

    }

    void OnDisable()
    {
        GameObject objToSpawn = Instantiate(prefabcubo);
        objToSpawn.name = "Cubo creado en OnDisable";
        objToSpawn.transform.position = new Vector3(2, 0, 0);
        objToSpawn.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}