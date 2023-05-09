using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class ActionScript : MonoBehaviour
{


    public InputActionReference inputActionReference = null;
    public GameObject controllerMenu = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {

        inputActionReference.action.started += ToggleMenu;
    }

    private void OnDestroy()
    {

        inputActionReference.action.started -= ToggleMenu;
    }


    private void ToggleMenu(InputAction.CallbackContext context)
    {
        Debug.Log("I´n ToggleMenu");
        if(controllerMenu.activeInHierarchy)
        {
            controllerMenu.SetActive(false);
        } else
        {
            controllerMenu.SetActive(true);
        }
    }
}
