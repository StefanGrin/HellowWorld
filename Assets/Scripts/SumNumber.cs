using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SumNumber : MonoBehaviour
{
    private int numbers;
    private int sum;
    private int _clickCount;
    private bool _endGame;

    public TextMeshProUGUI NumberLabel;
    public TextMeshProUGUI SumClickedLabel;
    public TextMeshProUGUI ClickCountLabel;

    

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            numbers = 1;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            numbers = 2;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            numbers = 3;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            numbers = 4;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            numbers = 5;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            numbers = 6;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            numbers = 7;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            numbers = 8;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            numbers = 9;
            SetNumText($"{numbers}");
            sum += numbers;
            _clickCount++;
        }

        SetSumClickedText($"Сумма нажатых цифр равна: {sum}.");
        
        if (sum >= 50)
        {
            SetClickCountText($"Игра окончена! Количество ходов :{_clickCount}.");
        }
        if (Input.GetKeyDown(KeyCode.Space) && (sum>=50))
        {
            sum = 0;
            SetSumClickedText($"Сумма нажатых цифр равна: {sum}.");
        }
    }

    private void SetNumText(string text)
    {
        Debug.Log(text);
        NumberLabel.text = text;
    }
    private void SetSumClickedText(string text)
    {
        Debug.Log(text);
        SumClickedLabel.text = text;
    }
    private void SetClickCountText(string text)
    {
        Debug.Log(text);
        ClickCountLabel.text = text;
    }
    
    
}