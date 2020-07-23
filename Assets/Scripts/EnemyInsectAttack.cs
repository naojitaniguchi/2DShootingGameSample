using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInsectAttack : MonoBehaviour
{
    public float waitTimeForAttack = 1.0f;
    public GameObject[] bullets;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 虫を発生させる
    IEnumerator Attack()
    {
        // 永久ループ
        while (true)
        {
            // ちょっと待つ
            yield return new WaitForSeconds(waitTimeForAttack);

            // ランダムを使って、どの方向の虫を出すかを決める
            int index = Random.Range(0, bullets.Length);

            // 虫を出す
            // インスタンス、場所、角度
            Instantiate(bullets[index], gameObject.transform.position, Quaternion.identity);
        }
    }
}
