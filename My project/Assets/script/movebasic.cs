using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebasic : MonoBehaviour
{
    

    private Rigidbody rb;
    [SerializeField] private float speed = 50f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionUpdate = transform.position - Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        transform.position = positionUpdate;
        Vector3 positionUpdate2 = transform.position - Input.GetAxis("Horizontal") * transform.right * speed * Time.deltaTime;
        transform.position = positionUpdate2;
    }
}