using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> ListadeCubos;
    public float FactorDeEscalamiento;
    public int numCubos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ListadeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "Cubo Numero" + numCubos;
        Color C = new Color (Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = C;
        tempGameObject.transform.position = Random.insideUnitSphere;

        ListadeCubos.Add(tempGameObject);
        List<GameObject> ObjetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in ListadeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= FactorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                ObjetosParaEliminar.Add(go);
            }
        }
        foreach (GameObject go in ObjetosParaEliminar)
            {
                ListadeCubos.Remove(go);
                Destroy(go);
            }
        }
    }
    
