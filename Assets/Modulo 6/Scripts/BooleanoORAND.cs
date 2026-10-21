using UnityEngine;

public class BooleanoORAND : MonoBehaviour
{
    public GameObject go3;
    public GameObject go4;
    public bool mivalor;
    private MeshRenderer mirenderer;
    private void Awake()
    {
        mirenderer = GetComponent<MeshRenderer>();

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
        bool valor3 = go3.GetComponent<BooleanoAND>().mivalor;
        bool valor4 = go4.GetComponent<BooleanoOR>().mivalor;
        mivalor = valor3 && valor4;
        if (mivalor)
        {
            mirenderer.material.color = Color.white;
        }
        else
        {
            mirenderer.material.color = Color.black;
        }

    }
}
