using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ProgressBar progressBar;

    public void SetProgressBarValue(int value)
    {
        Debug.Log(value);
        progressBar.SetValue(value);
    }

    public void SetProgressBarMaxValue(int maxValue)
    {
        Debug.Log(maxValue);
        progressBar.SetMaxValue(maxValue);
    }
}
