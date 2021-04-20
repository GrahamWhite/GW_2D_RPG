using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Enemy : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rb;
    public GameObject target;
    public GameObject bulletPreFab;
 
    public float defaultAngle = -90;
    public float bulletLife = 1000;
    public float bulletSpeed = 100;
    public float fireRate = 1;
    private float bulletTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Chase(GameObject target)
    {
       transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
   
    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.transform.position - transform.position;
        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle += defaultAngle, Vector3.forward);

        Chase(target);
                
        if(bulletTimer <= bulletLife)
        {
            bulletTimer += fireRate;
        }
        
    }
}
