using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starter_scene_2 : MonoBehaviour
{

    [SerializeField] public Button swithSceneButton;
    [SerializeField] public GameObject swithSceneButtonObject;
    void Start()
    {
        swithSceneButtonObject.SetActive(false);
        swithSceneButton.onClick.AddListener(SwitchScene);
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(0);
    }
}
