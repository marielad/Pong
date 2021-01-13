using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Collider2D collPlayer;
    int scorePlayer;
    public TextMeshProUGUI playerScore;

    void OnTriggerEnter2D(Collider2D col)
    {
        scorePlayer += 1;
        playerScore.text = scorePlayer.ToString();
    }
}
