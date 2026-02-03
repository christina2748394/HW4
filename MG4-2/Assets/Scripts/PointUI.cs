using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointUI : MonoBehaviour
{
    private int points = 0;
    [SerializeField] private TextMeshProUGUI _pointText;



    void Start()
    {
        Locator.Instance.Bird.Scored += HandleScored;
        Locator.Instance.Bird.Die += HandleDie;

    }


    public void HandleScored(int point)
    {
        points += point;
        _pointText.text = "Points: " + points.ToString();
    }
    public void HandleDie()
    {
        _pointText.text = "Game Over!";
    }
}
