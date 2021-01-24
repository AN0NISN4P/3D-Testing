using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector3 offset;
    float desiredAngle;
    Quaternion rotation;

    private void Start() {
        offset = target.transform.position - transform.position;
    }

    private void LateUpdate() {
        desiredAngle = target.transform.eulerAngles.y;
        rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);
    }
}
