using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insect : MonoBehaviour
{
    public Vector2 forceDir;
    public float force;
    public float lifeTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        forceDir.Normalize();
        gameObject.GetComponent<Rigidbody2D>().AddForce(forceDir * force);

        StartCoroutine(Life());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Life()
    {
        yield return new WaitForSeconds(lifeTime);

        Destroy(gameObject);
    }
}
