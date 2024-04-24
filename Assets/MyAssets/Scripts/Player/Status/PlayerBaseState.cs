using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState
{
    public Player player;

    public void SetPlayer(Player player)
    {
        this.player = player;
    }

    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void Update();
}
