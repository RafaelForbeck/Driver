using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState()
    {
        
    }

    public override void ExitState()
    {
        player.startPoint = player.transform.position;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.ChangeState(new PlayerRunState());
        }
    }
}
