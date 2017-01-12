using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 30f;
    public Rigidbody rigidbody;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W) || (Input.GetMouseButton(0) && Input.GetMouseButton(1)))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                rigidbody.AddForce(transform.forward * moveSpeed * 0.7f);
            }
            else
            {
                rigidbody.AddForce(transform.forward * moveSpeed);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(-transform.forward * moveSpeed * 0.7f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                rigidbody.AddForce(-transform.right * moveSpeed * 0.7f);
            }
            else
            {
                rigidbody.AddForce(-transform.right * moveSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                rigidbody.AddForce(transform.right * moveSpeed * 0.7f);
            }
            else
            {
                rigidbody.AddForce(transform.right * moveSpeed);
            }
        }
    }
    
}
