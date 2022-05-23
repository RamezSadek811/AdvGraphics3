using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
	
   public Camera mainCamera;
   public float speed = 0;

   private bool buttonReleased;

    

    void Update()
    {
      if(Input.GetMouseButton(1))
      {
	
	if(mainCamera.fieldOfView >= 30)
	{
	  mainCamera.fieldOfView -= 1;
	}

	if(mainCamera.fieldOfView >= 80)
	{
	  mainCamera.fieldOfView -= 2;
	}

	if(mainCamera.fieldOfView >= 100)
	{
	  mainCamera.fieldOfView -= 3;
	}
}
}
}
	
	