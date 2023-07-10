using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starter_scene_2 : MonoBehaviour
{

    [SerializeField] public Button swithSceneButton;
    [SerializeField] public GameObject swithSceneButtonObject;
    [SerializeField] public Button exitButton;
    void Start()
    {
        swithSceneButtonObject.SetActive(false);
        swithSceneButton.onClick.AddListener(SwitchScene);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(0);
    }
}
