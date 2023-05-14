using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDesign
{
    [CreateAssetMenu(fileName = "LevelDataScalable", menuName = "ScriptableObjects/LevelDataScalable", order = 2)]
    public class LevelDataScalable : ScriptableObject
    {
        [System.Serializable]
        public class LevelData
        {
            public int columns = 8;
            public int rows = 8;
            public int minWalls = 5;
            public int maxWalls = 9;
            public int minFood = 1;
            public int maxFood = 5;
            public int minEnemies = 1;
            public int maxEnemies = 5;
            public Vector3 playerStartPos = new Vector3(0, 0, 0f);
            public Vector3 exitPos = new Vector3(7, 7, 0f);
        }

        public LevelData[] levelDatas = new LevelData[] { };
    }
}
