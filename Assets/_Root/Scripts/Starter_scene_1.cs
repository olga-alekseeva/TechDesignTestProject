using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starter_scene_1 : MonoBehaviour
{
    [SerializeField] public Button swithSceneButton;
    [SerializeField] public Animator[] managingAnimator;
    void Start()
    {
        swithSceneButton.onClick.AddListener(SwitchScene);
        int i = 0;
        
        for ( i = 0; i < managingAnimator.Length; i++)
        {
            managingAnimator[i].enabled = false;
        }
        
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(1);
    }

}
