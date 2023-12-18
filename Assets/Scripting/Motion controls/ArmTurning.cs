using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmTurning : MonoBehaviour
{

    [SerializeField] Transform turningPoint;

    private void FixedUpdate()
    {
        Vector3 rotations = transform.localRotation.eulerAngles;
        turningPoint.localRotation = Quaternion.Euler(rotations.x, -rotations.y, -rotations.z);

    }

}
