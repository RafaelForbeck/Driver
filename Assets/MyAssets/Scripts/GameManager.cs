using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    public PlayerControl playerControl;
    private bool isInventoryOpen= false;

    private void Start()
    {
        SetupInventory(isInventoryOpen);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isInventoryOpen = !isInventoryOpen;
            SetupInventory(isInventoryOpen);
        }
    }

    private void SetupInventory(bool isOpen)
    {
        inventoryPanel.SetActive(isOpen);
        playerControl.SetController(!isOpen);
    }
}
