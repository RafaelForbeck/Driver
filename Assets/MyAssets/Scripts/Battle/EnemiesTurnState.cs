using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesTurnState : BattleBase
{
    public override void EnterState()
    {
        battle.enemySelection.DisableSelection();
        battle.StartEnemyTurn();
    }

    public override void ExitState()
    {
        battle.enemySelection.EnableSelection();
    }

    public override void UpdateState()
    {
        
    }
}
