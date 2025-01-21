using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	[SerializeField] private Joystick joystick;
	[SerializeField] private float speed;
	
	private Vector3 moveValues = new Vector3();
	private CharacterController controller;
	
	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
	
	private void SetValues()
	{
		moveValues.x = joystick.Horizontal;
		moveValues.z = joystick.Vertical;
	}
	
	private void Move()
	{
		Vector3 move = transform.right  * moveValues.x + transform.forward * moveValues.z;
		
		controller.Move(move * speed * Time.deltaTime);
	}
	
	private void Update()
	{
		SetValues();
		Move();
	}
}
