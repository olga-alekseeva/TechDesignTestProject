using UnityEngine;

public class ActivateCollider : MonoBehaviour
{
    [SerializeField] public Animator[] managingAnimator;
    public Collider2D gameObjectCollider;

    public void OnMouseDown()
    {
        int i = 0;

        for (i = 0; i < managingAnimator.Length; i++)
        {
            managingAnimator[i].enabled = true;
        }

    }
}
