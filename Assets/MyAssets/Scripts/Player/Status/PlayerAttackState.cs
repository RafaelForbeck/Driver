using UnityEngine;

internal class PlayerAttackState : PlayerBaseState
{
    public override void EnterState()
    {
        player.animator.SetTrigger("attack");
    }

    public override void ExitState()
    {
        
    }

    public override void Update()
    {
        
    }
}