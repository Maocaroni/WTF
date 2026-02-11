using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAndPos : MonoBehaviour
{
    private SpriteRenderer renderer;

    public GameObject redCube;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        transform.position = redCube.transform.position;
        ChangeColor();
    }

    //Metodo que cambia el color 

    public void ChangeColor()
    {
        renderer.color = Color.green;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
