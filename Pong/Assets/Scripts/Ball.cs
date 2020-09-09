using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called in Ball");
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5, 0, Random.Range(-7.5f, 7.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        counter++;
        if (counter % 5 == 0)
        {
            rb.velocity = new Vector3(rb.velocity.x * 1.3f, 0, rb.velocity.z * 1.3f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        rb.velocity = new Vector3(5, 0, Random.Range(-7.5f, 7.5f));
        transform.position = new Vector3(0, 0.5f, 0);
        counter = 0;
    }

}
