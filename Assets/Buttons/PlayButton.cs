using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{       
    public void LoadScene(String SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
