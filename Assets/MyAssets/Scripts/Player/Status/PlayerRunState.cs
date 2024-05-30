using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : PlayerBaseState
{
    public override void EnterState()
    {
        if (player.target == null)
        {
            player.ChangeState(new PlayerIdleState());
            return;
        }
        player.animator.SetTrigger("run");
    }

    public override void ExitState()
    {
        
    }

    public override void Update()
    {
        Move();
    }

    private void Move()
    {
        var vector = player.target.position - player.transform.position;
        vector = new Vector3(vector.x, 0, vector.z);
        var direction = vector.normalized;
        var displacement = direction * player.speed * Time.deltaTime;
        player.transform.position += displacement;

        if (vector.magnitude <= 1.3f)
        {
            player.ChangeState(new PlayerAttackState());
        }
    }
}
