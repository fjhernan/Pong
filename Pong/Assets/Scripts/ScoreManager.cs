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
        score.text = right_score + " : " + left_score;
    }

    // Update is called once per frame
    void Update()
    {
        if (lGoal.GetComponent<LeftGoal>().score > left_score && left_score < 11)
        {
            left_score = lGoal.GetComponent<LeftGoal>().score;
            score.text = + right_score + " :<color=red> " + left_score + "</color>";
            Debug.Log("Right Player scores!\nL: " + right_score + "   R: " + left_score);
        }
        if (rGoal.GetComponent<RightGoal>().score > right_score && right_score < 11)
        {
            right_score = rGoal.GetComponent<RightGoal>().score;
            score.text = "<color=blue>" + right_score + "</color> : " + left_score;
            Debug.Log("Left Player Scores!\nL: " + right_score + "   R: " + left_score);
        }

        if (lGoal.GetComponent<LeftGoal>().score >= 11)
        {
            Debug.Log("Right Player Win!");
            lGoal.GetComponent<LeftGoal>().score = 0;
            rGoal.GetComponent<RightGoal>().score = 0;
            left_score = 0;
            right_score = 0;
            score.text = "<color=red>Right Player Wins!</color>";

        }
        if (rGoal.GetComponent<RightGoal>().score >= 11)
        {
            Debug.Log("Left Player Wins!");
            lGoal.GetComponent<LeftGoal>().score = 0;
            rGoal.GetComponent<RightGoal>().score = 0;
            left_score = 0;
            right_score = 0;
            score.text = "<color=blue>Left Player Wins!</color>";
        }
    }
}
