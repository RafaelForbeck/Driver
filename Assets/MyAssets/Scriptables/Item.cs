using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable/Item",  order = 0)]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite sprite;
    public int count;
}
