using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Post : MonoBehaviour
{
    public InputActionReference postProcess = null;

    private void Awake() {
        postProcess.action.started += postToggle;
    }

    private void OnDestroy() {
        postProcess.action.started -= postToggle;
    }

    private void postToggle(InputAction.CallbackContext context){
        bool active = !gameObject.activeSelf;
        gameObject.SetActive(active);
    }
}
