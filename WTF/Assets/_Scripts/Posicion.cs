using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    private SpriteRenderer renderer;
    public GameObject blackCircle;

    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        transform.position = blackCircle.transform.position;
        ChangeColor();
    }

    //Metodo que cambia el color 

    public void ChangeColor()
    {
        renderer.color = Color.black;
        Debug.Log("La posición del circulo es:" + transform.position + " y su color es negro");

    }

   
}
