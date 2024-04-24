internal class PlayerAttackState : PlayerBaseState
{
    public override void EnterState()
    {
        player.Attack();
    }

    public override void ExitState()
    {
        
    }

    public override void Update()
    {
        
    }
}