using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    public Animator animator;
    public PlayerBaseState currentState;

    public Transform target;
    public float speed;
    public Vector3 startPoint;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GoToIdle();
    }

    public void ChangeState(PlayerBaseState newState)
    {
        if (currentState != null)
        {
            currentState.ExitState();
        }
        currentState = newState;
        currentState.SetPlayer(this);
        currentState.EnterState();
    }

    private void Update()
    {
        currentState.Update();
    }

    internal void Back()
    {
        ChangeState(new PlayerBackState());
    }

    internal void GoToIdle()
    {
        ChangeState(new PlayerIdleState());
    }
}
