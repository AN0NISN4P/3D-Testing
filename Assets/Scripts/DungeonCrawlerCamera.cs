using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCrawlerCamera : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector3 offset;
    Vector3 desiredPosition;

    private void Start() {
        offset = transform.position - target.transform.position;
    }

    void LateUpdate() {
        desiredPosition = target.transform.position + offset;
        transform.position = desiredPosition;
    }
}
