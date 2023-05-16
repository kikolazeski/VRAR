using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class grab : MonoBehaviour
{

    public Material mat1;
    public Material mat2;
    public Material mat3;
    //public Interaction interaction;
    public InputActionReference inputActionReference = null;
    GameObject obj;

    private void Awake()
    {

        inputActionReference.action.started += ToggleObject;
        inputActionReference.action.canceled+= ReleaseObject;
    }

    private void OnDestroy()
    {
        inputActionReference.action.started -= ToggleObject;
    }

    private void ToggleObject(InputAction.CallbackContext context)
    {
        Debug.Log("I´n ToggleObject");
        if (obj)
        {
            obj.GetComponent<MeshRenderer>().material = mat3;
        }
    }

    private void ReleaseObject(InputAction.CallbackContext context)
    {
        Debug.Log("I´n releaseObject");
        if (obj)
        {
            obj.GetComponent<MeshRenderer>().material = mat1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material = mat1;
        obj = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material = mat2;
        obj = null;
    }

}
