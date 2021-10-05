using UnityEngine;

namespace Platformer
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;

        private InputManager _inputManager = new InputManager();
        private PlayerAnimationController _playerAnimationController;

        private void Start()
        {
            _playerAnimationController = new PlayerAnimationController(_inputManager, _playerView);
        }

        private void Update()
        {
            _inputManager.Update();
            _playerAnimationController.Update();
        }
    }
}

