using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Inventory : MonoBehaviour {

    public List<GameObject> Slots = new List<GameObject>();
    public List<Item> Items = new List<Item>();
    public GameObject slots;
    int x = -110;
    int y = 110;
    ItemDatabase database;
    void Start()
    {
        int Slotamount = 0;
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        for (int i = 0; i < 5; i++)
        {
            for (int k = 0; k < 5; k++)
            {
                GameObject slot = (GameObject)Instantiate(slots);
                slot.GetComponent<SlotScript>().slotNumber = Slotamount;
                Slots.Add(slot);
                Items.Add(new Item());
                slot.transform.SetParent(this.gameObject.transform, false);
                slot.name = "Slot" + i + "." + k;
                slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
                x = x + 55;
                if(k == 4)
                {
                    x = -110;
                    y = y - 55;
                }

                Slotamount++;
            }
        }

        addItem(0);
        addItem(1);

      
    }

    void addItem(int id)
    {
        for (int i = 0; i < database.items.Count; i++)
        {
            if (database.items[i].itemID == id)
            {
                Item item = database.items[i];
                Items.Add(item);

                break;
            }
        }
    }
	
    void addItemAtEmptySlot(Item item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].itemName == null)
            {
                Items[i] = item;
                break;
            }

        }
    }
}
