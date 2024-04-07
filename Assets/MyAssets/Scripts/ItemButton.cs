using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public TMP_Text nameText;
    public Image image;
    private Item item;

    public void SetupButton(Item item)
    {
        nameText.text = item.name;
        image.sprite = item.sprite;
        this.item = item;
    }

    public void UseItem()
    {

    }
}
