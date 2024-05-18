using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public BattleBase currentState;
    public Player player;
    public PlayerWeapon playerWeapon;
    public EnemySelection enemySelection;
    public Enemies enemies;

    private void Start()
    {
        ChangeState(new PlayerTurnState());
        player.finishTurn = PlayerHasFinishedTheTurn;
        enemies.finishTurn = EnemyHasFinihedTheTurn;
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

    public void SetupPlayerButtons(bool enable)
    {
        playerWeapon.SetupButtons(enable);
    }

    public void PlayerHasFinishedTheTurn()
    {
        ChangeState(new EnemiesTurnState());
    }

    public void EnemyHasFinihedTheTurn()
    {
        ChangeState(new PlayerTurnState());
    }

    public void StartEnemyTurn()
    {
        enemies.Attack();
    }
}
