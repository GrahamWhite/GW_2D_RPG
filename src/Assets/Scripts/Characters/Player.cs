using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5;
    public Transform firePoint;

    public GameObject bulletPrefab;
    public float bulletForce = 10;


    float defaultSpriteAngle = -90;

   


    // Start is called before the first frame update
    void Start()
    {
       
    }

   
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            Debug.Log("Fire");
        }


        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 relativePos = targetPosition - transform.position;

        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle += defaultSpriteAngle, Vector3.forward);

        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x * speed, y * speed) * Time.deltaTime;        
    }
}
