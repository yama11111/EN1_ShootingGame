using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public EManager eM;
    public float walk = 0.0f;
    public float power = 1.0f;
    public int c = 0;

    public bool a = false;

    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (eM.count >= c)
        {
            if (walk > 0)
            {
                Vector3 pos = transform.position;
                pos.z -= power;
                walk -= power;
                transform.position = new Vector3(pos.x, pos.y, pos.z);
            }
            else
            {
                a = true;
            }
        }

        if (a)
        {
            transform.position = new Vector3(x, y, z);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}