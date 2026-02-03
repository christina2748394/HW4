using UnityEngine;

public class BirdController : MonoBehaviour
{
    public delegate void IntDelegate(int x);
    public event IntDelegate Scored;

    public delegate void Delegate();
    public event Delegate Die;

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _jumpForce;
    [SerializeField] public AudioSource _wing;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.linearVelocity = Vector2.up * _jumpForce;
            _wing.Play();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die?.Invoke();
        Time.timeScale = 0;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Score"))
        {
            Scored?.Invoke(1);
        }
    }

}
