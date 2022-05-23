using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsaclesPush : MonoBehaviour
{

    private float force=3.0f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var rigidBody = hit.collider.attachedRigidbody;

        if (rigidBody != null)
        {
            var forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rigidBody.AddForceAtPosition(forceDirection * force, transform.position, ForceMode.Impulse);


        }
    }
}