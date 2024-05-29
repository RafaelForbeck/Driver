using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySelection : MonoBehaviour
{
    private Player player;
    private List<GameObject> enemies;

    private Material selecetedMaterial;
    private Material unselecetedMaterial;

    private void Awake()
    {
        selecetedMaterial = Resources.Load<Material>("EnemyMateriels/SelectedEnemy");
        unselecetedMaterial = Resources.Load<Material>("EnemyMateriels/UnselectedEnemy");
    }

    private void Start()
    {
        UnselectAll();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitinfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitinfo);

            if (hit == false)
            {
                return;
            }

            if (hitinfo.transform.gameObject.tag != "Enemy")
            {
                return;
            }

            var mesh = hitinfo.transform.gameObject.GetComponent<MeshRenderer>();

            if (mesh == null)
            {
                return;
            }

            UnselectAll();
            mesh.material = selecetedMaterial;
            player.target = hitinfo.transform;
        }
    }

    void UnselectAll()
    {
        enemies = enemies.Where(x => x != null).ToList();
        foreach (var enemy in enemies) {
            enemy.GetComponent<MeshRenderer>().material = unselecetedMaterial;
        }
    }

    internal void Setup(GameObject playerGO, List<GameObject> enemiesGO)
    {
        player = playerGO.GetComponent<Player>();
        enemies = enemiesGO;
    }
}
