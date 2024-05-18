using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnState : BattleBase
{
    public override void EnterState()
    {
        battle.SetupPlayerButtons(true);
    }

    public override void ExitState()
    {
        battle.SetupPlayerButtons(false);
    }

    public override void UpdateState()
    {
        
    }
}
