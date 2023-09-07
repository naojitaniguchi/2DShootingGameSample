using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.1f;
    public float xMin = -20 ;
    public float beamInterval = 1.0f;
    public float angleStep = 30.0f;
    public GameObject beam;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ShotBeams");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (gameObject.transform.position.x < xMin)
        {
            Destroy(gameObject);
        }
    }
    private IEnumerator ShotBeams()
    {
        while (true)
        {
            yield return new WaitForSeconds(beamInterval);

            for ( float angle = 0.0f; angle < 360.0f; angle += angleStep)
            {
                Instantiate(beam, gameObject.transform.position, Quaternion.Euler(0.0f, 0.0f, angle));
            }
        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }

}
