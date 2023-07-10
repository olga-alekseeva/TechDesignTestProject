using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starter_scene_2 : MonoBehaviour
{

    [SerializeField] public Button swithSceneButton;
    void Start()
    {
        swithSceneButton.onClick.AddListener(SwitchScene);
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(0);
    }
}
