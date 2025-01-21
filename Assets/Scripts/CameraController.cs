using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	
	[SerializeField] private Transform playerBody;

	[SerializeField] private float sensivity;
	[SerializeField] private CameraControllerPanel cameraPanel;
	
	
	private float xRotation;
	private float yRotation;
	
	private float mouseX;
	private float mouseY;
		
	
	private void FixedUpdate()
	{
		if(cameraPanel.pressed)
		{
			CheckFinger();
			LookByFinger();
		}
	}
	
	private void CheckFinger()
	{
		foreach(Touch touch in Input.touches)
		{
			if(touch.fingerId == cameraPanel.fingerId)
			{
				if(touch.phase == TouchPhase.Moved)
				{
					mouseX = touch.deltaPosition.x + sensivity;
					mouseY = touch.deltaPosition.y + sensivity;
				}
				
				if(touch.phase == TouchPhase.Stationary)
				{
					mouseX = 0;
					mouseY = 0;
				}
			}
		}
	}
	
	private void LookByFinger()
	{
		xRotation -= mouseY;
		
		xRotation = Mathf.Clamp(xRotation, -90, 90);
		
		transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
		
		playerBody.Rotate(Vector3.up * mouseX);
	}
}
