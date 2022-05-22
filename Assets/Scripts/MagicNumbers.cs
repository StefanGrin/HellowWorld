using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int _min = 1;
    [SerializeField] private int _max = 1000;
    private int _guess;
    private int _guessCount;
    private bool _endGame;

    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public TextMeshProUGUI GuessCountLabel;
    public Button MoreButton;
    public Button LessButton;
    public Button FinishButton;
    public Button ResetButton;

    private void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        ResetButton.onClick.AddListener(ResetButtonClicked);
        SetInfoText($"Загадай число от {_min} до {_max}.");
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        _guess = (_max + _min) / 2;
        _guessCount++;

        SetGuessText($"Твое число {_guess}?");
        SetGuessCountText($"Количество попыток {_guessCount - 1}");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }

    private void SetGuessText(string text)
    {
        Debug.Log(text);
        GuessLabel.text = text;
    }

    private void SetGuessCountText(string text)
    {
        Debug.Log(text);
        GuessCountLabel.text = text;
    }

    private void MoreButtonClicked()
    {
        Debug.Log("Число больше");
        _min = _guess;
        CalculateGuess();
    }

    private void FinishButtonClicked()
    {
        _endGame = true;
        Debug.Log("Win");
        SetGuessText($"Твое число {_guess}!");
    }
    private void ResetButtonClicked()
    {
        if (_endGame)
        {
            _guess = 0;
            _max = 0;
            _min = 0;
            SetGuessText($"Твое число {_guess}!");
            SetInfoText($"Загадай число от {_min} до {_max}.");
        }
        
    }

    private void LessButtonClicked()
    {
        Debug.Log("Число меньше.");
        _max = _guess;
        CalculateGuess();
    }
}