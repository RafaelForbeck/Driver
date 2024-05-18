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

    public Transform target;
    public float speed;
    public float damage;

    private EnemyStatus status;
    private Vector3 startPoint;
    public Action finishTurn;

    private void Start()
    {
        status = EnemyStatus.idle;
    }

    private void Update()
    {
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
        if (vector.sqrMagnitude < delta.sqrMagnitude)
        {
            transform.position = startPoint;
            status = EnemyStatus.idle;
            finishTurn();
        }
    }

    public void StartAttack()
    {
        startPoint = transform.position;
        status = EnemyStatus.run;
    }

    private void OnTriggerEnter(Collider other)
    {
        print("enemy collider player");
        var life = other.GetComponent<Life>();

        if (life == null)
        {
            return;
        }

        life.TakeDamage(damage);

        if (status == EnemyStatus.run)
        {
            status = EnemyStatus.back;
        }
    }
}
