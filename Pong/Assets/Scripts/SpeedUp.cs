using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private float tTrack = 0;
    private bool spawned = false;
    public GameObject ball;
    private AudioSource aSource;
    public AudioClip clip1;
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
        ball = GameObject.Find("Ball");
        transform.position = new Vector3(0, 0, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawned == false)
        {
            tTrack += Time.deltaTime;
            if (tTrack > 8.0f)
            {
                Debug.Log("Ball has Spawned");
                transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 0f, Random.Range(-7.5f, 7.5f));
                tTrack = 0;
                spawned = true;
            }
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            if (ball.GetComponent<Ball>().counter < 40)
            {
                Debug.Log("Ball has sped up. SpeedUp has Despawned");
                aSource.PlayOneShot(clip1);
                ball.GetComponent<Ball>().rb.velocity = new Vector3(
                    ball.GetComponent<Ball>().rb.velocity.x * 1.5f, 0f,
                    ball.GetComponent<Ball>().rb.velocity.z * 1.5f);
                transform.position = new Vector3(0, 0, 20.0f);
                spawned = false;
            }
        }
    }
}
