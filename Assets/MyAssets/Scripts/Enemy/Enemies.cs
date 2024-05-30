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
    public Action battleEnded;

    private void Start()
    {
        //foreach (var enemy in enemies)
        //{
            
        //}
    }

    public void StartTurn()
    {
        enemies = enemies.Where(x => x != null).ToList();
        if (enemies.Count == 0)
        {
            battleEnded();
            return;
        }
        var index = UnityEngine.Random.Range(0, enemies.Count);
        var enemy = enemies[index];
        enemy.target = target;
        enemy.endedTurn = endedTurn;
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
