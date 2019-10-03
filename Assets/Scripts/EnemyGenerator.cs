using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public float interval;
    public float yMin;
    public float yMax;
    public float x;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Generate");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator Generate()
    {
        while (true)
        {
            Instantiate(enemy, new Vector3(x, Random.Range(yMin, yMax), 0.0f), Quaternion.identity);

            //3秒停止
            yield return new WaitForSeconds(interval);

        }

    }
}
