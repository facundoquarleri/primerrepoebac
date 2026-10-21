using UnityEngine;

public class TiposdeDatos : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 0;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("El valor de MiByteConSigno es: " + miByteConSigno);
        Debug.Log("El valor de miInt es: " + miInt);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno = (uint) miByteConSigno;
        Debug.Log("El valor de miIntSinSigno es: " + miIntSinSigno);
        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("El valor de miInt es: " + miInt);

        int a, b, c;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);


    }

    // Update is called once per frame
    void Update()
    {
        miShort += 3;
        Debug.Log(miShort);

    }
}
