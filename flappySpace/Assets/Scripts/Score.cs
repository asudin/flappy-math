using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [Header("Score Settings")]
    public static int score = 0;

    void Start()
    {
        score = 0;
    }

    // each time a player gets +1 score it changes it to sctring type 
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
