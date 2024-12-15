using System;
using System.Collections;

using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeLimit;
    public TextMeshProUGUI CountDown;
    public GameObject VictoryText;
    public GameObject DefeatText;
    public GameObject[] Enemies;
    public Healthbar PlayerHealth;

    void Start()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }
    void Update()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        timeLimit -= Time.deltaTime;
        CountDown.text = Mathf.RoundToInt(timeLimit).ToString();

        if (timeLimit <= 0 || PlayerHealth.CurrentHealth <= 0)
        {
            Time.timeScale = 0.5f;
            DefeatText.SetActive(true);
            StartCoroutine(ReturnToMenu());
        }

        if (Enemies.Length <= 0)
        {
            VictoryText.SetActive(true);
            StartCoroutine(ReturnToMenu());
        }
    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }
}
