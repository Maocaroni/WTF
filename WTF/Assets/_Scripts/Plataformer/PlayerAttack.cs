using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float bounceForce;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            if(_rb.velocity.y < 0)
            {
                _rb.AddForce(transform.up * bounceForce, ForceMode2D.Impulse);
                
                // --- AQUÍ AÑADIMOS LA ANIMACIÓN ---
                collision.GetComponent<Animator>().SetTrigger("Die");
                // ----------------------------------

                collision.GetComponent<EnemyMovement>().canMove = false;
                
                // Desactivamos el collider para que el personaje no siga chocando 
                // con el enemigo mientras este hace la animación de morir.
                collision.enabled = false; 

                Destroy(collision.gameObject, 1);
            }
        }
    }
}
