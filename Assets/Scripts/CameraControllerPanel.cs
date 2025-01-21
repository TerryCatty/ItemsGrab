using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraControllerPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	private bool _pressed;
	
	public bool pressed => _pressed;
	
	private int _fingerId;
	
	public int fingerId => _fingerId;
	
	
	public void OnPointerDown(PointerEventData eventData)
	{
		if(eventData.pointerCurrentRaycast.gameObject == gameObject)
		{
			_pressed = true;
			_fingerId = eventData.pointerId;
		}
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		_pressed = false;
	}
}
