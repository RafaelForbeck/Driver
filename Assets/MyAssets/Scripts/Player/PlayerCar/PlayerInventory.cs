using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Inventory inventory;

    private void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<ItemObject>();

        if (item == null)
        {
            return;
        }

        inventory.AddItem(item.item);
        Destroy(other.gameObject);
    }
}
