using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    GameObject leftPaddle, rightPaddle;

    // Start is called before the first frame update
    void Start()
    {
        leftPaddle = GameObject.Find("PaddleLeft");
        rightPaddle = GameObject.Find("PaddleRight");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            leftPaddle.transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime * 1.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            leftPaddle.transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime * -(1.0f));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightPaddle.transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime * 1.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rightPaddle.transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime * -(1.0f));
        }
    }
}
