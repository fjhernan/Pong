using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int left_score = 0, right_score = 0;
    GameObject lGoal, rGoal;
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        lGoal = GameObject.Find("LeftGoal");
        rGoal = GameObject.Find("RightGoal");
        score.text = left_score + " : " + right_score;
    }

    // Update is called once per frame
    void Update()
    {
        if (lGoal.GetComponent<LeftGoal>().score != left_score)
        {
            left_score = lGoal.GetComponent<LeftGoal>().score;
            Debug.Log("Left Player Scores!\nL: " + left_score + "   R: " + right_score);
        }
        if (rGoal.GetComponent<RightGoal>().score != right_score)
        {
            right_score = rGoal.GetComponent<RightGoal>().score;
            Debug.Log("Right Player Scores!\nL: " + left_score + "   R: " + right_score);
        }

        if (lGoal.GetComponent<LeftGoal>().score == 11)
        {
            Debug.Log("Left Player Win!");
            lGoal.GetComponent<LeftGoal>().score = 0;
            left_score = 0;
            right_score = 0;
        }
        if (rGoal.GetComponent<RightGoal>().score == 11)
        {
            Debug.Log("Right Player Wins!");
            rGoal.GetComponent<RightGoal>().score = 0;
            left_score = 0;
            right_score = 0;
        }
    }
}
