using System;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{

    [CreateAssetMenu(fileName = "FlameAnimatorConfig", menuName = "Configs/ FlameAnimation", order = 1)]
    public class FlameAnimationConfig : ScriptableObject
    {
        [Serializable]
        public sealed class SpriteSequence
        {
            //public AnimState Track;
            public List<Sprite> Sprites = new List<Sprite>();
        }

        public List<SpriteSequence> Sequence = new List<SpriteSequence>();
    }
}