using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municion : MonoBehaviour
{
    public int recargaBalas = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerShoot player = collision.GetComponent<PlayerShoot>();

        if (player != null)
        {
            player.disparosActuales += recargaBalas;

            // Limitar al máximo
            if (player.disparosActuales > player.maxDisparos)
            {
                player.disparosActuales = player.maxDisparos;
            }

            Debug.Log("Recargaste munición");

            Destroy(gameObject); // 
        }
    }
}
