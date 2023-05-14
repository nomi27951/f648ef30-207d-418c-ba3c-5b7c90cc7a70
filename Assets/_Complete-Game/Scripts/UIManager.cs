using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ProgressBar progressBar;

    public void SetProgressBarValue(int value)
    {
        progressBar.SetValue(value);
    }

    public void SetProgressBarMaxValue(int maxValue)
    {
        progressBar.SetMaxValue(maxValue);
    }
}
