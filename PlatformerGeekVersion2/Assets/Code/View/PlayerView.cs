using UnityEngine;

namespace Platformer
{
    public class PlayerView : MonoBehaviour
    {
        [HideInInspector] public Animator PlayerAnimator { get; private set; }
        [HideInInspector] public SpriteRenderer PlayerSpriteRenderer;

        private void Awake()
        {
            PlayerAnimator = GetComponent<Animator>();
            if (PlayerAnimator == null) Debug.Log("�� �������� Animator �� PlayerView");

            PlayerSpriteRenderer = GetComponent<SpriteRenderer>();
            if (PlayerSpriteRenderer == null) Debug.Log("�� �������� SpriteRenderer �� PlayerView");
        }
    }

}
