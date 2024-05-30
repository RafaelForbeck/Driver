using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager : MonoBehaviour
{
    public PlayerManager playerManager;
    public Battle battle;

    private void Start()
    {
        playerManager.startBattle = StartBattle;
        battle.battleEnded = BattleEnded;
    }

    public void StartBattle(Enemies enemies)
    {
        battle.SetEnemies(enemies);
    }

    public void BattleEnded()
    {
        playerManager.StartExploring();
    }
}
