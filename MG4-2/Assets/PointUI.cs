using UnityEngine;

public class PointUI : MonoBehaviour
{
    [SerializeField] TextmeshPro _pointText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Locator.GameController.Bird.Scored += HandleScored;

    }

    // Update is called once per frame
    public void HandleScored(int points)
    {
        _pointText = points;
    }
}
