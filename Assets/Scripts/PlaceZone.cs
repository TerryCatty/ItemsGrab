using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceZone : MonoBehaviour
{
	[SerializeField] private Inventory inventory;
	private void OnTriggerEnter(Collider collider)
	{
		if(collider.TryGetComponent(out PlayerItemKeeper itemKeeper))
		{
			if(itemKeeper.isTaken)
			{
				inventory.TryAddItem(itemKeeper.GetItem, itemKeeper);
			}
		}
	}
}
