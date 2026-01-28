using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    public BirdController Bird { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        GameObject playerObj = GameObject.FindWithTag("Player");
        Bird = playerObj.GetComponent<BirdController>();
    }

}
