using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
	
	private PlayerItemKeeper playerItemKeeper;
	
	private void Start()
	{
		playerItemKeeper = PlayerItemKeeper.instace;
	}
	
	public void SetDefault()
	{
		
		transform.localPosition = Vector3.zero;
		transform.localRotation = Quaternion.Euler(Vector3.zero);
	}
	
   private void OnMouseDown()
   {
		playerItemKeeper.TryPickUpItem(this);
   }
}
