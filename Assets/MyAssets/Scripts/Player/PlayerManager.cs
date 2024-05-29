using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Player player;
    public PlayerWeapon playerWeapon;
    public PlayerMovement playerMovement;

    private void Start()
    {
        StartExploring();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartBattle();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            StartExploring();
        }
    }

    public void StartBattle()
    {
        player.enabled = true;
        playerWeapon.enabled = true;
        playerMovement.enabled = false;
    }

    public void StartExploring()
    {
        player.enabled = false;
        playerWeapon.enabled = false;
        playerMovement.enabled = true;
    }
}
