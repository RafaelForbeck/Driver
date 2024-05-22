using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnState : BattleBase
{
    public override void EnterState()
    {
        battle.enemies.StartTurn();
    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {
        
    }
}
