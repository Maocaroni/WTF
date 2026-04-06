using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;


    private Transform currentPoint;

    private Rigidbody2D rb;


    public float speed;

    [HideInInspector] public bool canMove;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
        canMove = true;
    }


    void FixedUpdate()
    {
        if (canMove)
        {

            Movement();
            FlipMovement();
        }
        else
        {
            speed = 0f;
        }
    }

    private void Movement()
    {

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }
    }

    void FlipMovement()
    {
 
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

}

