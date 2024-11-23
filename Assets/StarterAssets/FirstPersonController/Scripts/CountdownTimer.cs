using System;
using System.Collections;

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeLimit;
    public TextMeshProUGUI CountDown;
    public GameObject VictoryText;
    public GameObject DefeatText;
    public GameObject[] Enemies;

    void Start()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }
    void Update()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        timeLimit -= Time.deltaTime;
        CountDown.text = Mathf.RoundToInt(timeLimit).ToString();

        if (timeLimit <= 0)
        {
            Time.timeScale = 0;
            DefeatText.SetActive(true);
        }

        if (Enemies.Length <= 0)
        {
            VictoryText.SetActive(true);
        }
    }
}
