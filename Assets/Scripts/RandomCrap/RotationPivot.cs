using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPivot : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.rotation *= Quaternion.Euler(moveDirection);
    }
}
