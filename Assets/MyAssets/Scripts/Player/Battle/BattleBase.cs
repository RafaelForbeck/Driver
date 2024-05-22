using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BattleBase
{
    public Battle battle;

    public void SetBattle(Battle battle)
    {
        this.battle = battle;
    }

    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void UpdateState();
}
