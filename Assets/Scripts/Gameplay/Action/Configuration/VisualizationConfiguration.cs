using System;
using UnityEngine;

namespace Unity.BossRoom.Gameplay.Configuration
{
    [CreateAssetMenu]
    public class VisualizationConfiguration : ScriptableObject
    {
        [Header("Animation Triggers")]
        [SerializeField] string m_AliveStateTrigger = "StandUp";
        [SerializeField] string m_FaintedStateTrigger = "FallDown";
        [SerializeField] string m_DeadStateTrigger = "Dead";
        [SerializeField] string m_AnticipateMoveTrigger = "AnticipateMove";
        [SerializeField] string m_EntryDeathTrigger = "EntryDeath";
        [SerializeField] string m_EntryFaintedTrigger = "EntryFainted";

        [Header("Other Animation Variables")]
        [SerializeField] string m_SpeedVariable = "Speed";
        [SerializeField] string m_BaseNodeTag = "BaseNode";

        [Header("Animation Speeds")]
        public float SpeedDead = 0;
        public float SpeedIdle = 0;
        public float SpeedNormal = 1;
        public float SpeedUncontrolled = 0; //no leg movement; character appears to be sliding helplessly
        public float SpeedSlowed = 2; //hyper leg movement (character appears to be working very hard to move)
        public float SpeedHasted = 1.5f;
        public float SpeedWalking = 0.5f;

        [Header("Associated Resources")]
        public GameObject TargetReticule;

        public Material ReticuleFriendlyMat;
        public Material ReticuleHostileMat;

        //these are maintained by our OnValidate(). Code refers to these hashed values, not the string versions.
        [SerializeField] [HideInInspector] public int AliveStateTriggerID;
        [SerializeField] [HideInInspector] public int FaintedStateTriggerID;
        [SerializeField] [HideInInspector] public int DeadStateTriggerID;
        [SerializeField] [HideInInspector] public int AnticipateMoveTriggerID;
        [SerializeField] [HideInInspector] public int EntryDeathTriggerID;
        [SerializeField] [HideInInspector] public int EntryFaintedTriggerID;
        [SerializeField] [HideInInspector] public int SpeedVariableID;
        [SerializeField] [HideInInspector] public int BaseNodeTagID;

        void OnValidate()
        {
            AliveStateTriggerID = Animator.StringToHash(m_AliveStateTrigger);
            FaintedStateTriggerID = Animator.StringToHash(m_FaintedStateTrigger);
            DeadStateTriggerID = Animator.StringToHash(m_DeadStateTrigger);
            AnticipateMoveTriggerID = Animator.StringToHash(m_AnticipateMoveTrigger);
            EntryDeathTriggerID = Animator.StringToHash(m_EntryDeathTrigger);
            EntryFaintedTriggerID = Animator.StringToHash(m_EntryFaintedTrigger);
            SpeedVariableID = Animator.StringToHash(m_SpeedVariable);
            BaseNodeTagID = Animator.StringToHash(m_BaseNodeTag);
        }
    }
}