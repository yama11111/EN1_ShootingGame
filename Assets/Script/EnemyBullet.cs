using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 1.0f;
    public float time = 2;
    protected Vector3 forward = new Vector3(0, 0, 1);
    protected Quaternion forwardAxis = Quaternion.identity;
    protected Rigidbody rb;
    protected GameObject enemy;

    Vector3 LeftBottom;
    Vector3 RightTop;

    // Start is called before the first frame update
    void Start()
    {
        var distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        LeftBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));

        rb = this.GetComponent<Rigidbody>();
        if (enemy != null)
        {
            forward = enemy.transform.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = forwardAxis * forward * speed;
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        time -= Time.deltaTime;
        if (time <= 0)
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerCollisionBody")
        {
            other.GetComponent<Player>().Damage();
            Destroy(this.gameObject);
        }
    }

    public void SetCharacterObject(GameObject character)
    {
        this.enemy = character;
    }

    public void SetForwardAxis(Quaternion axis)
    {
        this.forwardAxis = axis;
    }
}
