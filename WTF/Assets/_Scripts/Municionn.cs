using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municionn : MonoBehaviour

{
    public int recargaBalas = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerShoot player = collision.GetComponent<PlayerShoot>();

        if (player != null)
        {

            player.disparosActuales += recargaBalas;

        
            if (player.disparosActuales > player.maxDisparos)
            {
                player.disparosActuales = player.maxDisparos;
            }

            Debug.Log("Munición recogida. Ahora tienes: " + player.disparosActuales);
            Destroy(gameObject);
        }
    }
}