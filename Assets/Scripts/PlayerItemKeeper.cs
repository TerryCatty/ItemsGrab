using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemKeeper : MonoBehaviour
{
	public static PlayerItemKeeper instace;
	[SerializeField] private ItemObject currentItem;
	[SerializeField] private Transform placeItem;
	
	[SerializeField] private float maxDistance;
	
	public bool isTaken => currentItem != null;
	public ItemObject GetItem => currentItem;
	
	private void Awake()
	{
		if(instace != null) Destroy(gameObject);
		else instace = this;
	}
	
	public void TryPickUpItem(ItemObject item)
	{
		if(isTaken || Vector3.Distance(item.transform.position, transform.position) > maxDistance) return;
		
		currentItem = item;
		item.transform.SetParent(placeItem);
		item.SetDefault();
	}
	
	public void TryRemoveItem()
	{
		currentItem = null;
	}
}
