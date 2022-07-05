using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float power = 0.1f;

    Vector3 LeftBottom;
    Vector3 RightTop;

    public 

    // Start is called before the first frame update
    void Start()
    {
        var distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        LeftBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.z += power;

        transform.position = new Vector3(pos.x, pos.y, pos.z);

        if (pos.z >= 20)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x <= LeftBottom.x ||
            transform.position.x >= RightTop.x ||
            transform.position.z >= RightTop.z ||
            transform.position.z <= LeftBottom.z)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBody")
        {
            other.GetComponent<Enemy>().Damage();
            Destroy(this.gameObject);
        }
    }
}
