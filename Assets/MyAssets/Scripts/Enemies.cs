using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public List<EnemyAttack> enemies;

    public Transform playerTransform;

    public Action finishTurn;

    public void Attack()
    {
        var enemy = enemies[UnityEngine.Random.Range(0, enemies.Count)];
        enemy.target = playerTransform;
        enemy.StartAttack();
        enemy.finishTurn = finishTurn;
    }
}
