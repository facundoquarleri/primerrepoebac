using UnityEngine;


public class CrearCuboOnEnableOnDisable : MonoBehaviour
{

    Vector3[] vertices = {
            new Vector3 (0, 0, 0), //Vertice0
            new Vector3 (1, 0, 0), //Vertice1
            new Vector3 (1, 1, 0), //Vertice2
            new Vector3 (0, 1, 0), //Vertice3
            new Vector3 (0, 1, 1), //Vertice4
            new Vector3 (1, 1, 1), //Vertice5
            new Vector3 (1, 0, 1), //Vertice6
            new Vector3 (0, 0, 1), //Vertice7
            };
    int[] triangulos = {
            0, 2, 1, //Cara1
            0, 3, 2,
            2, 3, 4, //Cara2
            2, 4, 5,
            1, 2, 5, //Cara3
            1, 5, 6,
            0, 7, 4, //Cara4
            0, 4, 3,
            5, 4, 7, //Cara5
            5, 7, 6,
            0, 6, 7, //Cara6
            0, 1, 6,
            };
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
        GameObject objToSpawn = new GameObject("Cubo creado en OnEnable");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.green;
        objToSpawn.transform.position = new Vector3(-2, 0, 0);
    }

    void OnDisable()
    {
        GameObject objToSpawn = new GameObject("Cubo creado en OnDisable");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.red;
        objToSpawn.transform.position = new Vector3(2, 0, 0);
    }
}