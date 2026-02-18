using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private OldInput _oldInput;

    // Start is called before the first frame update
    void Start()
    {
        _oldInput = GetComponent <OldInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        transform.Translate(Vector3.right * _oldInput.horizontal * speed * Time.deltaTime);
    }
    
}
