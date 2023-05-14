using UnityEngine;
using System.Collections.Generic;

public class HighScoreManager
{
    private const string HighScoreKey = "HighScore";

    //Saving last 10 high scores
    public void SaveHighScore(int score)
    {
        var highScores = LoadHighScores();

        if (highScores.Count < 10 || score > highScores[highScores.Count - 1])
        {
            if (highScores.Count >= 10)
            {
                highScores.RemoveAt(highScores.Count - 1);
            }

            highScores.Add(score);
            highScores.Sort((a, b) => b.CompareTo(a));

            PlayerPrefs.SetString(HighScoreKey, string.Join(",", highScores.ConvertAll(score => score.ToString()).ToArray()));
            PlayerPrefs.Save();
        }
    }

    public List<int> LoadHighScores()
    {
        if (!PlayerPrefs.HasKey(HighScoreKey))
        {
            return new List<int>();
        }

        var highScoresString = PlayerPrefs.GetString(HighScoreKey);
        var highScores = new List<int>();
        foreach (var highScore in highScoresString.Split(','))
        {
            if (int.TryParse(highScore, out var score))
            {
                Debug.Log(score);
                highScores.Add(score);
            }
        }
        return highScores;
    }
}
