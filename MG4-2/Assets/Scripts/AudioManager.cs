using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public AudioSource _audioPoints;
    [SerializeField] public AudioSource _die;


    void Start()
    {
        Locator.Instance.Bird.Scored += HandleScored;
        Locator.Instance.Bird.Die += HandleDie;

    }


    public void HandleScored(int point)
    {

        _audioPoints.Play();

    }
    public void HandleDie()
    {
        _die.Play();

    }
}

