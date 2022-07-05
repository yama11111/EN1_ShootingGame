using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float power = 0.05f;

    Vector3 LeftBottom;
    Vector3 RightTop;

    private float Left, Right, Top, Bottom;

    // Start is called before the first frame update
    void Start()
    {
        var distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        LeftBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
        foreach (Transform child in gameObject.transform)
        {
            if (child.localPosition.x >= Right)  Right  = child.transform.localPosition.x;
            if (child.localPosition.x <= Left)   Left   = child.transform.localPosition.x;
            if (child.localPosition.z >= Top)    Top    = child.transform.localPosition.z;
            if (child.localPosition.z <= Bottom) Bottom = child.transform.localPosition.z;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) pos.x += power;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))  pos.x -= power;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))    pos.z += power;
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))  pos.z -= power;

        transform.position = new Vector3(
            Mathf.Clamp(pos.x, LeftBottom.x + transform.localScale.x - Left, RightTop.x - transform.localScale.x - Right),
            pos.y,
            Mathf.Clamp(pos.z, LeftBottom.z + transform.localScale.z - Bottom, RightTop.z - transform.localScale.z - Top));
    }
}
