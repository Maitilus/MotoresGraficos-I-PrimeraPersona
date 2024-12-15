using System;
using System.Collections;
using System.ComponentModel;
using UnityEngine;

public class HideObj : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(HideText());
    }

    IEnumerator HideText()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
