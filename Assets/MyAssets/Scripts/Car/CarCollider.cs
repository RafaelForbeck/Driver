using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollider : MonoBehaviour
{
    public PlayerStatus playerStatus;

    private void OnTriggerEnter(Collider other)
    {
        var carStatus = other.GetComponent<CarStatus>();

        if (carStatus == null) { return; }

        playerStatus.GetInCar();
        carStatus.MovePlayerIn(playerStatus.transform);
    }
}
