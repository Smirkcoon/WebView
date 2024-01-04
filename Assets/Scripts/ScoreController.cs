using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int score;
    [SerializeField] private TMP_Text ScoreCountText;

    public void AddOneScore()
    {
        score++;
        ScoreCountText.text = score.ToString();
    }
}
