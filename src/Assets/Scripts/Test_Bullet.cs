using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Bullet : MonoBehaviour
{


    public float bulletLifeSpan = 5;
    float currentLifeSpan = 0;
    CapsuleCollider2D col;
    public bool destoryOnContact = true;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision && collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (currentLifeSpan < bulletLifeSpan)
        {
            currentLifeSpan += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

      

    }
}
