using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform startPos;
    public int maxDisparos = 3;
    private int disparosActuales = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shoot(InputAction.CallbackContext context)

    {
        Debug.Log("Dispara");
        if(context.started)
        {
            if (disparosActuales < maxDisparos)
            {
            
                GameObject bulletClone = Instantiate(bullet, startPos.position, startPos.rotation);
                Destroy(bulletClone, 1);
                disparosActuales = disparosActuales + 1;
            }
        }
    }
}
