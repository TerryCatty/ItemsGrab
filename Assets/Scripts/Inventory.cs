using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	[SerializeField] private List<Cell> cells;
	
	public void TryAddItem(ItemObject item, PlayerItemKeeper playerItemKeeper)
	{
		int index = -1;
		
		foreach(Cell cell in cells)
		{
			if(!cell.isTake)
			{
				index = cells.IndexOf(cell);
				break;
			}
		}
		
		if(index == -1)
		{
			return;
		}
		
		cells[index].item = item;
		item.transform.SetParent(cells[index].point);
		item.SetDefault();
		
		playerItemKeeper.TryRemoveItem();
	}
}

[Serializable]
public class Cell
{
	public bool isTake => item != null;
	public ItemObject item;
	public Transform point;
}
