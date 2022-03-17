using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [Header("Score Settings")]
    public static int _score = 0;

    void Start()
    {
        _score = 0;
    }

    // Passing score to input field
    void Update()
    {
        GetComponent<TMP_Text>().text = _score.ToString();
    }
}
