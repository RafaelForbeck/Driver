using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Player player;
    public PlayerWeapon playerWeapon;
    public PlayerMovement playerMovement;
    public Action<Enemies> startBattle;

    private void Start()
    {
        StartExploring();
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

    private void OnTriggerEnter(Collider other)
    {
        var enemies = other.GetComponent<Enemies>();

        if (enemies == null)
        {
            return;
        }

        other.GetComponent<Collider>().enabled = false;

        startBattle(enemies);
        StartBattle();
    }
}
