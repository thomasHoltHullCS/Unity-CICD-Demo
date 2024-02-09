using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 10.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) { rb.MovePosition(transform.position + rb.transform.forward * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.S)) { rb.MovePosition(transform.position - rb.transform.forward * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.A)) { rb.MovePosition(transform.position - rb.transform.right * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.D)) { rb.MovePosition(transform.position + rb.transform.right * speed * Time.deltaTime); }
    }
}
