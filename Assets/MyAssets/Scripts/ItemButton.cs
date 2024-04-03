using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public TMP_Text nameText;
    public Image image;

    public void SetupButton(Item item)
    {
        nameText.text = item.name;
        image.sprite = item.sprite;
    }
}
