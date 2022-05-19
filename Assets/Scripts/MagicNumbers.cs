using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int _min = 1;
    [SerializeField] private int _max = 1000;
    private int _guess;

    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public Button MoreButton;
    public Button LessButton;
    public Button FinishButton;

    private void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        SetInfoText($"Загадай число от {_min} до {_max}.");
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        _guess = (_max + _min) / 2;
        SetGuessText($"Твое число {_guess}?");
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

    private void MoreButtonClicked()
    {
        Debug.Log("Число больше");
        _min = _guess;
        CalculateGuess();
    }

    private void FinishButtonClicked()
    {
        Debug.Log("Win");
        SetGuessText($"Твое число {_guess}!");
    }

    private void LessButtonClicked()
    {
        Debug.Log("Число меньше.");
        _max = _guess;
        CalculateGuess();
    }
}