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
            if (PlayerAnimator == null) Debug.Log("Не назначен Animator на PlayerView");

            PlayerSpriteRenderer = GetComponent<SpriteRenderer>();
            if (PlayerSpriteRenderer == null) Debug.Log("Не назначен SpriteRenderer на PlayerView");
        }
    }

}
