using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Creacion variables
    [Header("Numeros")]
    public int a;
    public int b;

    private int result;

    // Start is called before the first frame update
    void Start()
    {
        Suma();
    }

    //Suma de dos numeros 
    public void Suma()
    {
        result = a + b;


        //Escribe el resultado en la consola
        Debug.Log("El resultado es:" + result);
        Debug.Log(string.Format("El resultado es {0}", result));


    }


}
