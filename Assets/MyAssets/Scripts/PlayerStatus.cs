using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerControl))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class PlayerStatus : MonoBehaviour
{
    PlayerControl playerControl;
    Rigidbody rb;
    Collider playerCollider;

    private void Awake()
    {
        playerControl = GetComponent<PlayerControl>();
        rb = GetComponent<Rigidbody>();
        playerCollider = GetComponent<Collider>();
    }

    public void GetInCar()
    {
        playerControl.TurnOffControl();
        rb.isKinematic = true;
        playerCollider.enabled = false;
    }
    public void GetOutCar()
    {
        playerControl.TurnOnControl();
        rb.isKinematic = false;
        playerCollider.enabled = true;
    }
}
