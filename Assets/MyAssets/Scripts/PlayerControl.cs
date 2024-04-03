using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float walkSpeed;
    public float turnSpeed;
    public GameObject carCollider;

    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
        var turn = Input.GetAxis("Mouse X");

        var z = transform.forward * vertical;
        var x = transform.right * horizontal;

        var displacement = x + z;

        transform.position += displacement * walkSpeed * Time.deltaTime;

        var yRotate = turn * turnSpeed;
        transform.Rotate(new Vector3(0f, yRotate, 0f));

        if (Input.GetKeyDown(KeyCode.F))
        {
            carCollider.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            carCollider.SetActive(false);
        }
    }

    public void TurnOffControl()
    {
        carCollider.SetActive(false);
        enabled = false;
    }

    public void TurnOnControl()
    {
        enabled = true;
    }

    public void SetController(bool controllerOn)
    {
        if (controllerOn)
        {
            TurnOnControl();
        } else
        {
            TurnOffControl();
        }
    }
}
