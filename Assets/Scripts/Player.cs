using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector3 rotationInputs;
    [SerializeField] float rotationSpeed;
    [SerializeField] float moveSpeed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotationInputs = new Vector3(0, Input.GetAxisRaw("Horizontal"), 0) * rotationSpeed;
        rb.rotation *= Quaternion.Euler(rotationInputs);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            rb.velocity = transform.forward * moveSpeed;
        else
            rb.velocity = Vector3.zero;
    }
}
