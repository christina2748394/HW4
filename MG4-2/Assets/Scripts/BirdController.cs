using UnityEngine;

public class BirdController : MonoBehaviour
{
    public delegate void IntDelegate(int x);
    public event IntDelegate Scored;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scored?.Invoke(1);

    }
}
