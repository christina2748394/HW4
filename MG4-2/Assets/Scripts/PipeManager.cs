using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject PipePrefab;

    private Vector3 position = new Vector3(4f, 0.17f, 0f);

    private float randomHeight;
    [SerializeField] private float waitTime = 1.5f;
    private float Timer = 0f;


    void Start()
    {
        randomHeight = Random.Range(-0.38f, 0.44f);
    }

    void Update()
    {
        Timer += Time.deltaTime;
        SpawnPipe();

    }

    void SpawnPipe()
    {
        if (Timer >= waitTime)
        {
            Instantiate(PipePrefab, position, Quaternion.identity);
            Timer = 0f;
            randomHeight = Random.Range(-0.38f, 0.44f);
            position.y = randomHeight;
        }
    }
}
