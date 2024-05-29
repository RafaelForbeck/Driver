using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * speed * vertical * Time.deltaTime;
        transform.Rotate(Vector3.up, horizontal * turnSpeed);
    }
}
