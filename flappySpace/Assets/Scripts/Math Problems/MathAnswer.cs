using UnityEngine;

public class MathAnswer : MonoBehaviour
{
    [SerializeField] GameObject problem, answerFieldTop, answerFieldBot;

    MathProblem answer;

    private int _solution, _answerHolder, _answerDif, _subDiv, _wrongAnswer;

    private void Awake()
    {
        answer = problem.GetComponent<MathProblem>();
    }

    void Start()
    {
        _solution = answer.GetProblem();
        RandomAnswer();
        AnswerHolder();
    }

    // Randomizes numbers for answer fields
    private void RandomAnswer()
    {
        _answerHolder = Random.Range(1, 3);
        _answerDif = Random.Range(1, 3);
        _subDiv = Random.Range(1, 5);
    }

    public void AnswerHolder()
    {
        _wrongAnswer = _solution;

        Debug.Log($"answerHolder is: {_answerHolder}");
        switch (_answerHolder)
        {
            // In this case the right answer always spawns at the top opening
            case 1:
                Debug.Log($"answerDiv case1 is: {_subDiv}");

                // Using a randomized number in order to add/subtract from the wrong answer field
                switch (_subDiv)
                {
                    case 1:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution + _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 2:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution - _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 3:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution + _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 4:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution - _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    default:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution - _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;
                }
                break;

            // In this case the right answer always spawns at the bot opening
            case 2:
                Debug.Log($"answerDiv case2 is: {_subDiv}");

                // Using a randomized number in order to add/subtract from the wrong answer field
                switch (_subDiv)
                {
                    case 1:
                        _wrongAnswer = _solution + _answerDif;
                        answerFieldTop.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldTop.GetComponent<Collider2D>().isTrigger = false;

                        answerFieldBot.GetComponent<TextMesh>().text = _solution.ToString();

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 2:
                        _wrongAnswer = _solution - _answerDif;
                        answerFieldTop.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldTop.GetComponent<Collider2D>().isTrigger = false;

                        answerFieldBot.GetComponent<TextMesh>().text = _solution.ToString();

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 3:
                        _wrongAnswer = _solution - _answerDif;
                        answerFieldTop.GetComponent<TextMesh>().text = _wrongAnswer.ToString();


                        answerFieldBot.GetComponent<TextMesh>().text = _solution.ToString();

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 4:
                        _wrongAnswer = _solution - _answerDif;
                        answerFieldTop.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldTop.GetComponent<Collider2D>().isTrigger = false;

                        answerFieldBot.GetComponent<TextMesh>().text = _solution.ToString();

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    default:
                        _wrongAnswer = _solution - _answerDif;
                        answerFieldTop.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldTop.GetComponent<Collider2D>().isTrigger = false;

                        answerFieldBot.GetComponent<TextMesh>().text = _solution.ToString();

                        Debug.Log($"BINGO: {_solution}");
                        break;
                }
                break;

            // The default script to spawn the right answer at the top
            default:
                Debug.Log($"answerDiv default is: {_subDiv}");

                // Using a randomized number in order to add/subtract from the wrong answer field
                switch (_subDiv)
                {
                    case 1:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution + _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 2:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution - _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 3:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution + _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    case 4:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution - _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;

                    default:
                        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

                        _wrongAnswer = _solution - _answerDif;

                        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
                        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

                        Debug.Log($"BINGO: {_solution}");
                        break;
                }
                break;
        }
    }
}