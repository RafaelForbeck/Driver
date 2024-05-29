using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemySelection))]
[RequireComponent(typeof(Enemies))]
public class EnemiesManager : MonoBehaviour
{
    private GameObject playerGO;
    private List<GameObject> enemiesGO = new List<GameObject>();

    private EnemySelection enemySelection;
    private Enemies enemies;

    private void Awake()
    {
        playerGO = GameObject.Find("Player");
        foreach (Transform child in transform)
        {
            enemiesGO.Add(child.gameObject);
        } 

        enemySelection = GetComponent<EnemySelection>();
        enemies = GetComponent<Enemies>();

        enemySelection.Setup(playerGO, enemiesGO);
        enemies.Setup(playerGO, enemiesGO);
    }
}
