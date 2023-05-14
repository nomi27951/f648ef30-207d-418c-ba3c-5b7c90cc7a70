using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Completed;

namespace GameDesign
{
    [CreateAssetMenu(fileName = "NewGameMode", menuName = "Tools/GameMode", order = 1)]
    public class GameMode : ScriptableObject
    {
        public float levelStartDelay = 2f;                      //Time to wait before starting level, in seconds.
        public float turnDelay = 0.1f;                          //Delay between each Player turn.
        public int playerFoodPoints = 100;                      //Starting value for Player food points.
    }
}
