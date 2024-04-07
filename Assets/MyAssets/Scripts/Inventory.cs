using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Transform contentTransform;
    public GameObject buttonModel;
    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        var buttonGO = Instantiate(buttonModel, contentTransform);
        var itemButton = buttonGO.GetComponent<ItemButton>();
        itemButton.SetupButton(item);


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ClearInventory();
        }
    }

    void ClearInventory()
    {
        while (contentTransform.childCount > 0)
        {
            DestroyImmediate(contentTransform.GetChild(0).gameObject);
        }
    }
}
