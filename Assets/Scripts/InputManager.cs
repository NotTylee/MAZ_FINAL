using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private Contols playerInput;
    private Contols.ControlsActions actions;
    private PlayerLook look;
   
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new Contols();
        actions = playerInput.Controls;
       look = GetComponent<PlayerLook>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
     look.ProcessLook(actions.Look.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
       actions.Enable();
    }
    private void OnDisable()
    {
       actions.Disable();
    }
}
