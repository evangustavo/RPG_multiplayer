using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.BossRoom.Gameplay.Actions
{
    [Serializable]
    public class ActionConfig
    {
        public ActionLogic Logic;
        public int Amount;
        public int ManaCost;
        public float Range;
        public float DurationSeconds;
        public float ExecTimeSeconds;
        public float EffectDurationSeconds;
        public float ReuseTimeSeconds;
        public string AnimActicipation;
        public string Anim;
        public string Anim2;
        public string ReactAnim;
        public string OtherAnimatorVariable;
        public int SplashDamage;
        public float MoveSpeed;
        public float KnockbackSpeed;
        public float KnockbackDuration;
        public float Radius;
        public BaseActionInput ActionInput;
        public bool ActionInterruptible;
        public List<Action> IsInterruptableBy;
        public BlockingModeType BlockingMode;
        public ProjectileInfo[] Projectiles;
        public GameObject[] Spawns;
        public bool IsFriendly;
        public Sprite Icon;
        public string DisplayedName;
        public string Description;
        
        public bool CanBeInterruptedBy(ActionID actionActionID)
        {
            foreach (var action in IsInterruptableBy)
            {
                if (action.ActionID == actionActionID)
                {
                    return true;
                }
            }

            return false;
        }
    }
}