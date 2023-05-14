using UnityEngine;

namespace GameDesign
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData", order = 1)]
    public class LevelData : ScriptableObject
    {
        public int[] enemiesPerLevel = new int[] { };
        public Vector3 playerStartPos = new Vector3(0, 0, 0f);
        public Vector3 exitPos = new Vector3(7, 7, 0f);

        public int GetEnemiesPerLevel(int level)
        {
            level = Mathf.Max(1, level);
            level = Mathf.Min(level, enemiesPerLevel.Length);

            return enemiesPerLevel[level - 1] > 0 ? enemiesPerLevel[level - 1] : (int)Mathf.Log(level, 2f);
        }
    }
}
