using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public PlayerWeapon playerWeapon;
    public Player player;
    public Enemies Enemies { get; private set; }

    public BattleBase currentState;
    public Action battleEnded;

    private void Awake()
    {
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

    public void BattleEnded()
    {
        battleEnded();
    }

    public void SetEnemies(Enemies enemies)
    {
        Enemies = enemies;
        enemies.battleEnded = BattleEnded;
        enemies.endedTurn = EnemyEndedTurn;
    }
}
