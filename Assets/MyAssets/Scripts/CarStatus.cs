using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarControl))]
public class CarStatus : MonoBehaviour
{
    CarControl carControl;
    public Transform playerPosition;
    public Transform outPlayerPosition;
    public Transform camPosition;

    private void Awake()
    {
        carControl = GetComponent<CarControl>();
    }

    public void MovePlayerIn(Transform playerTransform)
    {
        playerTransform.parent = playerPosition;
        playerTransform.localPosition = Vector3.zero;
        playerTransform.localRotation = Quaternion.identity;
        carControl.enabled = true;
    }

    public void MovePlayerOut()
    {
        var playerTransform = playerPosition.GetChild(0);
        playerTransform.parent = null;
        playerTransform.position = outPlayerPosition.position;
        carControl.enabled = false;
        var playerStatus = playerTransform.GetComponent<PlayerStatus>();
        if (playerStatus == null) { return; }
        playerStatus.GetOutCar();
    }
}
