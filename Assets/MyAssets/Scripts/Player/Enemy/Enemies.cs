using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public List<EnemyAttack> enemies;
    public Transform target;
    public Action endedTurn;

    public void StartTurn()
    {
        var index = UnityEngine.Random.Range(0, enemies.Count);
        var enemy = enemies[index];
        enemy.target = target;
        enemy.endedTurn = endedTurn;
        enemy.Attack();
    }
}
