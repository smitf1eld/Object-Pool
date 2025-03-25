using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsText : MonoBehaviour
{
    ButtonClick ButtonClick;
    [SerializeField]
    public static int Count;
    [SerializeField]
    private TextMeshProUGUI pointtext;
    void Start()
    {
        pointtext.text = Count.ToString();
    }

    void Update()
    {
        Count = ButtonClick.totalScore;
        pointtext.text = Count.ToString();
    }
}
