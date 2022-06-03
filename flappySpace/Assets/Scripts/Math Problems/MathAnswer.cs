using UnityEngine;

public class MathAnswer : MonoBehaviour
{
    [SerializeField] GameObject problem, answerFieldTop, answerFieldBot;

    MathProblem answer;

    private int _solution;
    private int _answerHolder;
    private int _answerDifferentiator;
    private int _correctAnswerField;
    private int _wrongAnswer;
    private int _minNumberRange = 1;
    private int _middleNumberRange = 3;
    private int _maxNumberRange = 5;

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

    public void AnswerHolder()
    {
        _wrongAnswer = _solution;

        Debug.Log($"answerHolder is: {_answerHolder}");
        switch (_answerHolder)
        {
            // In this case the right answer always spawns at the top opening
            case 1:
                Debug.Log($"answerDiv case1 is: {_correctAnswerField}");

                // Using a randomized number to create wrong answers for user to lose upon collision
                switch (_correctAnswerField)
                {
                    case 1:
                        ShowTopAnswerAddition();
                        break;
                    case 2:
                        ShowTopAnswerDivision();
                        break;
                    default:
                        ShowTopAnswerDivision();
                        break;
                }
                break;

            // In this case the right answer always spawns at the bot opening
            case 2:
                Debug.Log($"answerDiv case2 is: {_correctAnswerField}");

                // Using a randomized number in order to add/subtract from the wrong answer field
                switch (_correctAnswerField)
                {
                    case 1:
                        ShowBotAnswerAddition();
                        break;
                    case 2:
                        ShowBotAnswerDivision();
                        break;
                    default:
                        ShowBotAnswerAddition();
                        break;
                }
                break;

            // The default script to spawn the right answer at the top
            default:
                Debug.Log($"answerDiv default is: {_correctAnswerField}");

                // Using a randomized number in order to add/subtract from the wrong answer field
                switch (_correctAnswerField)
                {
                    case 1:
                        ShowTopAnswerAddition();
                        break;
                    case 2:
                        ShowTopAnswerDivision();
                        break;
                    default:
                        ShowTopAnswerDivision();
                        break;
                }
                break;
        }
    }

    private void RandomAnswer()
    {
        _answerHolder = Random.Range(_minNumberRange, _middleNumberRange);
        _answerDifferentiator = Random.Range(_minNumberRange, _middleNumberRange);
        _correctAnswerField = Random.Range(_minNumberRange, _maxNumberRange);
    }

    private void ShowTopAnswerAddition()
    {
        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

        _wrongAnswer = _solution + _answerDifferentiator;

        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

        Debug.Log($"BINGO: {_solution}");
    }

    private void ShowTopAnswerDivision()
    {
        answerFieldTop.GetComponent<TextMesh>().text = _solution.ToString();

        _wrongAnswer = _solution - _answerDifferentiator;

        answerFieldBot.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
        answerFieldBot.GetComponent<Collider2D>().isTrigger = false;

        Debug.Log($"BINGO: {_solution}");
    }

    private void ShowBotAnswerAddition()
    {
        _wrongAnswer = _solution + _answerDifferentiator;
        answerFieldTop.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
        answerFieldTop.GetComponent<Collider2D>().isTrigger = false;

        answerFieldBot.GetComponent<TextMesh>().text = _solution.ToString();

        Debug.Log($"BINGO: {_solution}");
    }

    private void ShowBotAnswerDivision()
    {
        _wrongAnswer = _solution - _answerDifferentiator;
        answerFieldTop.GetComponent<TextMesh>().text = _wrongAnswer.ToString();
        answerFieldTop.GetComponent<Collider2D>().isTrigger = false;

        answerFieldBot.GetComponent<TextMesh>().text = _solution.ToString();

        Debug.Log($"BINGO: {_solution}");
    }
}