using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Transform contentTransform;
    public GameObject buttonModel;

    public void AddItem(Item item)
    {
        var buttonGO = Instantiate(buttonModel, contentTransform);
        var itemButton = buttonGO.GetComponent<ItemButton>();
        itemButton.SetupButton(item);
    }
}
