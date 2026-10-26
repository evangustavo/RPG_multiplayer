using System;
using Unity.BossRoom.Gameplay.GameplayObjects.Character;
using Unity.BossRoom.Infrastructure;
using UnityEngine;
using Action = Unity.BossRoom.Gameplay.Actions.Action;

namespace Unity.BossRoom.Gameplay.Configuration
{
    [CreateAssetMenu(menuName = "GameData/CharacterClass", order = 1)]
    public class CharacterClass : ScriptableObject
    {
        public CharacterTypeEnum CharacterType;
        public Action Skill1;
        public Action Skill2;
        public Action Skill3;
        public IntVariable BaseHP;
        public int BaseMana;
        public float Speed;
        public bool IsNpc;
        public float DetectRange;
        public string DisplayedName;
        public Sprite ClassBannerLit;
        public Sprite ClassBannerUnlit;
    }
}