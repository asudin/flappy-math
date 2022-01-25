using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathAnswer : MonoBehaviour
{
    MathProblem answer;
    [SerializeField] GameObject problem;
    private int solution;

    private void Awake()
    {
        answer = problem.GetComponent<MathProblem>();
    }

    void Start()
    {
        solution = answer.GetProblem();
        //Debug.Log($"this is the solution: {solution}");

        GetComponent<TextMesh>().text = solution.ToString();
    }
}
