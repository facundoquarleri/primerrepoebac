using UnityEngine;
using UnityEngine.UIElements;

public class BooleanoFixedUpdate : MonoBehaviour
{
    

    public bool mivalor = false;
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
        mivalor = !mivalor;
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
