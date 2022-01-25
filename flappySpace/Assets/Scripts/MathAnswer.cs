using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathAnswer : MonoBehaviour
{
    [SerializeField] GameObject problem;
    [SerializeField] GameObject answerFieldTop, answerFieldBot;

    MathProblem answer;

    private int solution, answerHolder, answerDif, subDiv;

    private void Awake()
    {
        answer = problem.GetComponent<MathProblem>();
    }

    void Start()
    {
        solution = answer.GetProblem();
        RandomAnswer();
        AnswerHolder();
    }

    // used to randomize numbers
    private void RandomAnswer()
    {
        answerHolder = Random.Range(1, 3);
        answerDif = Random.Range(1, 3);
        subDiv = Random.Range(1, 5);
    }

    public void AnswerHolder()
    {
        Debug.Log($"answerHolder is: {answerHolder}");
        switch (answerHolder)
        {
            // in this case the right answer always spawns at the top opening
            case 1:
                Debug.Log($"answerDiv case1 is: {subDiv}");
                // using a randomized number in order to add/subtract from the wrong answer field
                switch (subDiv)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        
                        solution = solution + subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution + subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 4:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    default:                    
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                }
                break;

            // in this case the right answer always spawns at the bot opening
            case 2:
                Debug.Log($"answerDiv case2 is: {subDiv}");
                // using a randomized number in order to add/subtract from the wrong answer field
                switch (subDiv)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution + subDiv;
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution + subDiv;
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 4:
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    default:
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                }
                break;

            // just the default script to spawn the right answer at the top
            default:
                Debug.Log($"answerDiv default is: {subDiv}");
                // using a randomized number in order to add/subtract from the wrong answer field
                switch (subDiv)
                {
                    case 1:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution + subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 2:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 3:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution + subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    case 4:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                    default:
                        GameObject.FindGameObjectWithTag("topAnswer").GetComponent<TextMesh>().text = solution.ToString();

                        solution = solution - subDiv;
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<TextMesh>().text = solution.ToString();
                        GameObject.FindGameObjectWithTag("botAnswer").GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {solution}");
                        break;
                }
                break;
        }
    }
}