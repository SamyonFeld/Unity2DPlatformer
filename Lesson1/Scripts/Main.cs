using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private int _animationSpeed = 10;
        [SerializeField] private SpriteAnimationConfig _playerConfig;
        [SerializeField] private SpriteAnimationConfig _flameConfig;
        [SerializeField] private LevelObjectView _playerView;
        [SerializeField] private LevelObjectView _flameView;
        private SpriteAnimatorController _playerAnimator;
        private SpriteAnimatorController _flameAnimator;

        void Awake()
        {
            _playerConfig = Resources.Load<SpriteAnimationConfig>("PlayerAnimationConfig");
            _playerAnimator = new SpriteAnimatorController(_playerConfig);
            _playerAnimator.StartAnimation(_playerView._spriteRenderer, AnimState.Run, true, _animationSpeed);

            _flameConfig = Resources.Load<SpriteAnimationConfig>("FlameAnimationConfig");
            _flameAnimator = new SpriteAnimatorController(_flameConfig);
            _flameAnimator.StartAnimation(_flameView._spriteRenderer, AnimState.Idle, true, _animationSpeed);
        }

        void Update()
        {
            _playerAnimator.Update();
            _flameAnimator.Update();
        }
        private void FixedUpdate()
        {

        }
    }
}