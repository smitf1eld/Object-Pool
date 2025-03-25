using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    PointsText PointsText;
    ButtonClick ButtonClick;
    void Awake()
    {
        ButtonClick.totalScore = 0;
        PointsText.Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
