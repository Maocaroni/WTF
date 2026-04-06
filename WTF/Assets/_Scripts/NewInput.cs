
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInput : MonoBehaviour
{

    private PlayerInput playerInput;
    private PlayerJump _playerJump;
    [HideInInspector] public float inputX;


    private void Start()
    {

        playerInput = GetComponent<PlayerInput>();
        _playerJump = GetComponent<PlayerJump>();
    }


    private void Update()
    {
    
        GetInput();
    }

    public void Button(InputAction.CallbackContext context)
    {
 
        if (context.started)
        {
            _playerJump.Jump();
        }
    }

  
    public void GetInput()
    {
   
        inputX = playerInput.actions["Move"].ReadValue<float>();
    }
}
