using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeam : MonoBehaviour
{
    public float speed = 0.1f;
    public float xMax = 20.0f;
    public float xMin = -20.0f;
    public float yMax = 10.0f;
    public float yMin = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 moveVec = gameObject.transform.rotation * Vector3.right * speed * -1.0f;
        gameObject.transform.position += moveVec;
        if (gameObject.transform.position.x > xMax)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x < xMin)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y > yMax)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y < yMin)
        {
            Destroy(gameObject);
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }        
    }
}
