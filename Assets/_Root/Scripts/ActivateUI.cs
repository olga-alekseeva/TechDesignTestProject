using UnityEngine;

public class ActivateUI : MonoBehaviour
{
    [SerializeField] Collider2D gameObjectCollider;
    [SerializeField] GameObject nextSceneButtton;
    public void OnMouseDown()
    {
        nextSceneButtton.SetActive(true);
    }
}
