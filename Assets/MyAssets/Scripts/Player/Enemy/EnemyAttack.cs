using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    enum EnemyStatus
    {
        idle,
        run,
        back
    }

    EnemyStatus status;
    Vector3 startPoint;
    
    public Transform target;
    public float speed;
    public float damage;
    public Action endedTurn;

    private void Start()
    {
        startPoint = transform.position;
        status = EnemyStatus.idle;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }

        switch (status)
        {
            case EnemyStatus.idle:
                UpdateIdle();
                break;
            case EnemyStatus.run:
                UpdateRun();
                break;
            case EnemyStatus.back:
                UpdateBack();
                break;
        }
    }

    void UpdateIdle()
    {

    }

    void UpdateRun()
    {
        var vector = target.position - transform.position;
        var delta = vector.normalized * speed * Time.deltaTime;
        transform.position += delta;
    }

    void UpdateBack()
    {
        var vector = startPoint - transform.position;
        var delta = vector.normalized * speed * Time.deltaTime;
        transform.position += delta;
        if (delta.sqrMagnitude > vector.sqrMagnitude) // chegou
        {
            transform.position = startPoint;
            status = EnemyStatus.idle;
            // Avisar a o Enemies que o turno do inimigo acabou
            endedTurn();
        }
    }

    public void Attack()
    {
        status = EnemyStatus.run;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (status != EnemyStatus.run)
        {
            return;
        }

        var life = other.GetComponent<Life>();

        if (life != null)
        {
            life.TakeDamage(damage);
            status = EnemyStatus.back;
        }
    }
}
