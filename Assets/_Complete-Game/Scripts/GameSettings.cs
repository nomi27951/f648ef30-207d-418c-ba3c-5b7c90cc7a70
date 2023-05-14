using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings", order = 1)]
public class GameSettings : ScriptableObject
{
    public int foodCap = 100;
    public string foodCapExceededMessage = "Food cap reached!";
}
