using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootColor : MonoBehaviour
{
    public GameObject bullet1;
    public Transform startPos;
    public int maxDisparos = 3;
    public int disparosActuales;

    void Start()
    {

        disparosActuales = maxDisparos;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {

            if (disparosActuales > 0)
            {
                Debug.Log("Disparo realizado!");
                Instantiate(bullet1, startPos.position, startPos.rotation);

                disparosActuales--;
            }
            else
            {
                Debug.Log("Sin munición, busca una caja!");
            }
        }
    }
}
