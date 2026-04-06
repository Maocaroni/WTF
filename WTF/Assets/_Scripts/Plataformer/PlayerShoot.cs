using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [Header("Configuración de Balas")]
    public GameObject bullet;      
    public GameObject bullet1;      
    private GameObject currentBullet; 

    public Transform startPos;
    public int maxDisparos = 3;
    public int disparosActuales;

    void Start()
    {
        disparosActuales = maxDisparos;
        currentBullet = bullet; 
    }

    void Update()
    {
       
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            SwitchBullet();
        }
    }

    void SwitchBullet()
    {s
        if (currentBullet == bullet)
        {
            currentBullet = bullet1;
            Debug.Log("Equipada: Bala 2");
        }
        else
        {
            currentBullet = bullet;
            Debug.Log("Equipada: Bala 1");
        }
    }

   
    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started && disparosActuales > 0)
        {
            
            Instantiate(currentBullet, startPos.position, startPos.rotation);
            disparosActuales--;
            Debug.Log("Disparo con " + currentBullet.name + ". Quedan: " + disparosActuales);
        }
        else if (context.started && disparosActuales <= 0)
        {
            Debug.Log("¡Sin munición!");
        }
    }
}