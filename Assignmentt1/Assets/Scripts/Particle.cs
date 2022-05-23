using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Particle : MonoBehaviour
{
    public InputActionReference color = null;
    private ParticleSystem ps;

    private void Awake() {
        ps = GetComponent<ParticleSystem>();
        color.action.started += ChangeColor; 
    }



    private void ChangeColor(InputAction.CallbackContext context){
        var main = ps.main;

        if(main.startColor.color == Color.green){
            main.startColor = Color.white;
            Debug.Log("White");
        }else{
             main.startColor = Color.green;
             Debug.Log("Green");
        }


        
    }
}
