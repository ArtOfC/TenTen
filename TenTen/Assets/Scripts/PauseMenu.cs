﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenuUI;

    public void Resume()
    {
        _pauseMenuUI.SetActive(false);
    }

    public void Pause()
    {
        _pauseMenuUI.SetActive(true);
    }

    public void GoBackToMainMenu()
    {
        SaveLoad.Instance().Save();
        SaveLoad.Instance().Clear();
        SceneManager.LoadScene(0);
    }
}
