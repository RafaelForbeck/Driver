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
        this.item = item;
        this.action = action;
        UpdateCountText();
    }

    public void AddCount()
    {
        item.count++;
        UpdateCountText();
    }

    public void UseItem()
    {
        item.count--;
        action(item);
        UpdateCountText();
    }

    private void UpdateCountText()
    {
        countText.text = item.count.ToString();
    }
}
