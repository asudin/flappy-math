using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float _slowdownFactor = 0.2f;
    private float _slowdownLength = 2f;

    // Slowly return to normal time
    private void Update()
    {
        Time.timeScale += (1f / _slowdownLength) * Time.unscaledDeltaTime;
    }

    // Smooth slowmo time
    public void DoSlowmotion()
    {
        Time.timeScale = _slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
