using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    private int score = 0;

    public int get_score()
    {
        return score;
    }

    public void add_score(int x)
    {
        score += x;
    }


}
