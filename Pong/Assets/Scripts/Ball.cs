using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public int counter = 0;
    private AudioSource aSource;
    public AudioClip clip1, clip2, clip3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called in Ball");
        rb = GetComponent<Rigidbody>();
        aSource = GetComponent<AudioSource>();
        int direct = Random.Range(0, 2);
        if(direct == 0){
            rb.velocity = new Vector3(5, 0, Random.Range(-7.5f, 7.5f));
        }
        else{
            rb.velocity = new Vector3(-5, 0, Random.Range(-7.5f, 7.5f));
        }
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
            aSource.PlayOneShot(clip1);
        }
        if(collision.gameObject.name == "PaddleLeft" || collision.gameObject.name == "PaddleRight"){
            aSource.PlayOneShot(clip2);    
        }
        if(collision.gameObject.name == "UpperWall" || collision.gameObject.name == "LowerWall")
        {
            aSource.PlayOneShot(clip3);
        }
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.name == "RightGoal"){
           rb.velocity = new Vector3(5, 0, Random.Range(-7.5f, 7.5f));
            transform.position = new Vector3(0, 0.5f, 0);
            counter = 0;
        }
        if(other.gameObject.name == "LeftGoal"){
            rb.velocity = new Vector3(-5, 0, Random.Range(-7.5f, 0f));
            transform.position = new Vector3(0, 0.5f, 0);
            counter = 0;
        }
    }

}
