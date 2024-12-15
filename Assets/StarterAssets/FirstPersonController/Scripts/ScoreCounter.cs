using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public PlayerScore Score;

    void Start()
    {
        ScoreText.text = $"Score: {Score.CurrentScore}/{Score.TotalCoins.Length} \n Enemies Left: {Score.TotalEnemies.Length / 2}";
    }

    void Update()
    {
        ScoreText.text = $"Score: {Score.CurrentScore}/{Score.TotalCoins.Length} \n Enemies Left: {Score.TotalEnemies.Length / 2}";
    }
}
    