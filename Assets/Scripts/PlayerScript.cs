using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] int movementSpeed;
    [SerializeField] int turningSpeed;

    private float horizontal;
    private float vertical;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * movementSpeed* Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        transform.Translate(0, 0, vertical);
    }
}
