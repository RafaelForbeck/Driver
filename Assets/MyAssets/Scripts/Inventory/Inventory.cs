using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Transform contentTransform;
    public GameObject buttonModel;

    public List<Item> items = new List<Item>();
    public List<ItemButton> itemButtons = new List<ItemButton>();

    private void Start()
    {
        foreach (var item in items)
        {
            if (item.count > 0)
            {
                InstantiateItemButton(item);
            }
        }
    }
    public void AddItem(Item item)
    {
        foreach (ItemButton button in itemButtons) {
            if (button.item == item)
            {
                button.AddCount();
                return;
            }
        }

        InstantiateItemButton(item);
    }

    private void InstantiateItemButton(Item item)
    {
        var buttonGO = Instantiate(buttonModel, contentTransform);
        var itemButton = buttonGO.GetComponent<ItemButton>();
        itemButton.SetupButton(item, UseItem);

        itemButtons.Add(itemButton);
    }

    public void UseItem(Item item)
    {
        print("Estou dentro do script do inventário e o item é o " + item.name);
    }
}
