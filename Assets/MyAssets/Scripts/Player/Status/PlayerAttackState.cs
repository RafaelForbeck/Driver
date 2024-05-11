using UnityEngine;

internal class PlayerAttackState : PlayerBaseState
{
    public override void EnterState()
    {
        player.currentWeapon.Attack(player);
    }

    public override void ExitState()
    {
        
    }

    public override void Update()
    {
        
    }
}