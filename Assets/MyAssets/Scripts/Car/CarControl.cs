using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarStatus))]
public class CarControl : MonoBehaviour
{
    public WheelCollider frontLeft;
    public WheelCollider frontRight;
    public WheelCollider rearLeft;
    public WheelCollider rearRight;

    public Transform frontLeftMesh;
    public Transform frontRightMesh;
    public Transform rearLeftMesh;
    public Transform rearRightMesh;

    public float acceleration;
    public float steerAngle;
    public float breakForce;

    List<WheelCollider> frontWheels = new List<WheelCollider>();
    List<WheelCollider> rearWheels = new List<WheelCollider>();
    List<WheelCollider> wheels = new List<WheelCollider>();

    List<Transform> wheelsTransforms = new List<Transform>();

    public Rigidbody rig;
    CarStatus carStatus;

    private void Awake()
    {
        carStatus = GetComponent<CarStatus>();
    }

    void Start()
    {
        rig.centerOfMass = new Vector3(0, 0, 0);

        frontWheels.Add(frontLeft);
        frontWheels.Add(frontRight);

        rearWheels.Add(rearLeft);
        rearWheels.Add(rearRight);

        wheels.Add(frontLeft);
        wheels.Add(frontRight);
        wheels.Add(rearLeft);
        wheels.Add(rearRight);

        wheelsTransforms.Add(frontLeftMesh);
        wheelsTransforms.Add(frontRightMesh);
        wheelsTransforms.Add(rearLeftMesh);
        wheelsTransforms.Add(rearRightMesh);
    }

    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        foreach (var wheel in frontWheels)
        {
            wheel.motorTorque = vertical * Time.deltaTime * acceleration * 10000;
            wheel.steerAngle = horizontal * steerAngle;
        }

        for (int i = 0; i < wheels.Count; i++)
        {
            Quaternion rotation;
            Vector3 position;

            var wheel = wheels[i];
            wheel.GetWorldPose(out position, out rotation);

            var wheelTransform = wheelsTransforms[i];

            wheelTransform.position = position;
            wheelTransform.rotation = rotation;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            foreach (var wheel in wheels)
            {
                wheel.brakeTorque = breakForce;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            foreach (var wheel in wheels)
            {
                wheel.brakeTorque = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.F)) {
            carStatus.MovePlayerOut();
        }
    }
}
