using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float amplitude;
    [SerializeField] private float step;
    private float startAmplitude;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startAmplitude = amplitude;
    }

    // Update is called once per frame
    public void Restart()
    {
        amplitude = startAmplitude;
        rb.MovePosition(Vector3.zero);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * amplitude; // change to send to losing side
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "PaddleLeft" || collision.gameObject.name == "PaddleRight")
        {
            //play sound

<<<<<<< HEAD
            amplitude += step;
            float offset = Mathf.Pow((transform.position.z - collision.transform.position.z), 2);
            offset = (transform.position.z - collision.transform.position.z < 0) ? offset * -1 : offset;

            rb.velocity = (collision.gameObject.name == "PaddleLeft")
                ? new Vector3(amplitude, 0, offset)
                : new Vector3(-amplitude, 0, offset);
=======
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.name == "RightGoal"){
           rb.velocity = new Vector3(5, 0, Random.Range(-7.5f, 7.5f));
        }
        if(other.gameObject.name == "LeftGoal"){
            rb.velocity = new Vector3(-5, 0, Random.Range(-7.5f, 0f));
>>>>>>> parent of 82336f9... Pong Project Part 1A edits
        }
        

    }


}
