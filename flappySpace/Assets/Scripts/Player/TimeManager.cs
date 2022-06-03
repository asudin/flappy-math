using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float _slowdownFactor = 0.2f;
    private float _slowdownLength = 2f;

    private void Update()
    {
        Time.timeScale += (1f / _slowdownLength) * Time.unscaledDeltaTime;
    }

    public void DoSlowmotion()
    {
        Time.timeScale = _slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
