using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public PlayerWeapon playerWeapon;
    public Player player;
    public Enemies enemies;

    public BattleBase currentState;

    private void Start()
    {
        enemies.endedTurn = EnemyEndedTurn;
        player.endedTurn = PlayerEndedTurn;
        ChangeState(new PlayerTurnState());
    }

    public void ChangeState(BattleBase newState)
    {
        if (currentState != null)
        {
            currentState.ExitState();
        }
        currentState = newState;
        currentState.SetBattle(this);
        currentState.EnterState();
    }

    public void PlayerEndedTurn()
    {
        ChangeState(new EnemyTurnState());
    }

    public void EnemyEndedTurn()
    {
        ChangeState(new PlayerTurnState());
    }
}
