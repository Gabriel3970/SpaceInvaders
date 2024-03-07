using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0000;
    string scoreString;
    string leadingNums;
    public int hiscore = 0000;
    public TextMeshPro scoreTextLeft;

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void OnScore(int id)
    {
        if (id == 1){
            score += 3;
        }
        if(id == 2){
            score += 5;
        }
        if(id == 3){
            score += 10;
        }
        if(id == 4){
            score += 20;
        }
        UpdateScores();
    }

    public void UpdateScores()
    {
        if(score < 10){
            leadingNums = "000";
            scoreString = score.ToString();
            scoreString = leadingNums + scoreString;
            scoreTextLeft.text = scoreString;
        }
        else if(score > 10 && score < 100){
            leadingNums = "00";
            scoreString = score.ToString();
            scoreString = leadingNums + scoreString;
            scoreTextLeft.text = scoreString;
        }
        else if(score > 100 && score < 1000){
            leadingNums = "0";
            scoreString = score.ToString();
            scoreString = leadingNums + scoreString;
            scoreTextLeft.text = scoreString;
        }
        else{
            scoreString = score.ToString();
            scoreTextLeft.text = scoreString;
        }
        // scoreString = score.ToString();
        // scoreTextLeft.text = scoreString;
    }

    // public void SetScore(int value)
    // {
    //     text.text = value.ToString();
    // }
}
