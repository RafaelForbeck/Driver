using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySelection : MonoBehaviour
{
    public Player player;
    public List<GameObject> enemies;

    public Material selecetedMaterial;
    public Material unselecetedMaterial;

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

    public void DisableSelection()
    {
        UnselectAll();
        enabled = false;
    }

    public void EnableSelection()
    {
        enabled = true;
    }
}
