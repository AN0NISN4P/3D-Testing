using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float damping;
    Vector3 offset;
    float currentAngle;
    float desiredAngle;
    float angle;
    Quaternion rotation;

    private void Start() {
        offset = target.transform.position - transform.position;
    }

    private void LateUpdate() {
        currentAngle = transform.eulerAngles.y;
        desiredAngle = target.transform.eulerAngles.y;
        angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);
        rotation = Quaternion.Euler(0, angle, 0);
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);
    }
}
