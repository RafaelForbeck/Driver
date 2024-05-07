using UnityEngine;

internal class PlayerBackState : PlayerBaseState
{
    public override void EnterState()
    {
        
    }

    public override void ExitState()
    {
        player.animator.SetTrigger("idle");
    }

    public override void Update()
    {
        var vector = player.startPoint - player.transform.position;
        var direction = vector.normalized;
        var displacement = direction * player.speed * 3 * Time.deltaTime;
        player.transform.position += displacement;
        if (vector.magnitude < 0.1f)
        {
            player.transform.position = player.startPoint;
            player.ChangeState(new PlayerIdleState());
        }
    }
}