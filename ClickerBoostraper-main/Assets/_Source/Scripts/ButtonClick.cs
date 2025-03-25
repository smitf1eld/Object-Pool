using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [System.Serializable]
    public class ClickableButton
    {
        public Button button;
        public int score;
    }

    [SerializeField] private List<ClickableButton> clickableButtons = new List<ClickableButton>();
    public static int totalScore = 0;

    private void Start()
    {
        foreach (var item in clickableButtons)
        {
            if (item.button != null)
            {
                item.button.onClick.AddListener(() => AddScore(item.score));
            }
        }
    }

    private void AddScore(int amount)
    {
        totalScore += amount;
        Debug.Log("Общий счет: " + totalScore);
    }
}