using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public TMP_Text nameText;
    public Image image;
    public TMP_Text countText;
    public Item item;
    Action<Item> action;

    public void SetupButton(Item item, Action<Item> action)
    {
        nameText.text = item.name;
        image.sprite = item.sprite;
        countText.text = item.count.ToString();
        this.item = item;
        this.action = action;
    }

    public void AddCount()
    {
        item.count++;
        countText.text = item.count.ToString();
    }

    public void UseItem()
    {
        action(item);
    }
}
