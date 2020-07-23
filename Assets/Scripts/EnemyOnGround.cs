using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOnGround : MonoBehaviour
{
    public float velocity = 1.0f;
    public float minMoveTime = 1.0f;
    public float maxMoveTime = 3.0f;
    float moveTime;
    float dir = 1.0f;
    public float xMax = 4.0f;
    public float xMin = -4.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * dir;
        StartCoroutine(move());
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x > xMax)
        {
            dir = -1.0f;
        }
        if (gameObject.transform.position.x < xMin)
        {
            dir = 1.0f;
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * dir;

    }

    IEnumerator move()
    {
        while (true)
        {
            // 待ち時間をランダムで設定
            moveTime = Random.Range(minMoveTime, maxMoveTime);

            // 待ち時間を設定
            yield return new WaitForSeconds(moveTime);
            dir *= -1.0f;
        }
    }
}
