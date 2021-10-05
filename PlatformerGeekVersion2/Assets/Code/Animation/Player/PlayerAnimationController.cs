
namespace Platformer
{
    public class PlayerAnimationController
    {
        private ConstanceAnimation _constanceAnim = new ConstanceAnimation();
        private InputManager _inputManager;
        private PlayerView _playerView;

        public PlayerAnimationController(InputManager inputManager, PlayerView playerView)
        {
            _inputManager = inputManager;
            _playerView = playerView;
        }

        public void Update()
        {
            Move();
            Jump();
        }

        private void Move()
        {
            bool run;

            if (_inputManager.Horizontal > 0)
            {
                run = true;
                _playerView.PlayerSpriteRenderer.flipX = false;
            }
            else if (_inputManager.Horizontal < 0)
            {
                run = true;
                _playerView.PlayerSpriteRenderer.flipX = true;
            }
            else
            {
                run = false;
            }

            _playerView.PlayerAnimator.SetBool(_constanceAnim.RUN, run);
        }

        private void Jump()
        {
            bool jump;

            if (_inputManager.Jump)
            {
                jump = true;
            }
            else
            {
                jump = false;
            }

            _playerView.PlayerAnimator.SetBool(_constanceAnim.JUMP, jump);
        }
    }
}

