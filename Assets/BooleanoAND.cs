using UnityEngine;

public class BooleanoAND : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public bool mivalor;
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
        
    }
    private void FixedUpdate()
    {
        bool valor1 = go1.GetComponent<BooleanoFixedUpdate>().mivalor;
        bool valor2 = go2.GetComponent<BooleanoFixedUpdate>().mivalor;
        mivalor = valor1 && valor2;
        if (mivalor)
        {
            miRenderer.material.color = Color.white;
        
        }
        else
        {
            miRenderer.material.color = Color.black;


        }

    }
}
