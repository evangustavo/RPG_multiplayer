using UnityEngine;
using Random = UnityEngine.Random;

namespace Unity.BossRoom.Gameplay.Configuration
{
    [CreateAssetMenu(menuName = "GameData/NameGeneration", order = 2)]
    public class NameGenerationData : ScriptableObject
    {
        public string[] FirstWordList;
        public string[] SecondWordList;
        
        public string GenerateName()
        {
            var firstWord = FirstWordList[Random.Range(0, FirstWordList.Length)];
            var secondWord = SecondWordList[Random.Range(0, SecondWordList.Length)];

            return firstWord + " " + secondWord;
        }
    }
}