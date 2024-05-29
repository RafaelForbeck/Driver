using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    private List<EnemyAttack> enemies = new List<EnemyAttack>();
    private Transform target;
    public Action endedTurn;

    private void Start()
    {
        foreach (var enemy in enemies)
        {
            enemy.endedTurn = endedTurn;
            enemy.target = target;
        }
    }

    public void StartTurn()
    {
        enemies = enemies.Where(x => x != null).ToList();
        if (enemies.Count == 0)
        {
            // A batalha acabou
            print("A batalha acabou");
            return;
        }
        var index = UnityEngine.Random.Range(0, enemies.Count);
        var enemy = enemies[index];
        enemy.Attack();
    }

    internal void Setup(GameObject playerGO, List<GameObject> enemiesGO)
    {
        target = playerGO.transform;
        foreach (var enemy in enemiesGO)
        {
            enemies.Add(enemy.GetComponent<EnemyAttack>());
        }
    }
}
