using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject bullet;
    public int maxDamage = 10;
    public Text damageText;
    public GameObject gameOver;
    private int damage;

    void Start()
    {
        damage = maxDamage;
        damageText.text = "Damage:" + damage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "EnemyBeam")
        {
            damage--;
            if ( damage <= 0)
            {
                gameOver.SetActive(true);
            }
            damageText.text = "Damage:" + damage.ToString();

        }
    }

}
