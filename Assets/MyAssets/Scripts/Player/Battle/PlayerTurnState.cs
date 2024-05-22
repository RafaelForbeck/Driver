using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnState : BattleBase
{
    public override void EnterState()
    {
        battle.playerWeapon.SetupButtons(true);
    }

    public override void ExitState()
    {
        battle.playerWeapon.SetupButtons(false);
    }

    public override void UpdateState()
    {
        
    }
}
