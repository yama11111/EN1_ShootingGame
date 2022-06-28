using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForwardShot : MonoBehaviour
{
    private GameObject player;
    public GameObject bullet;
    public float time = 1;
    public float delayTime = 1;
    float nowTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        nowTime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        nowTime -= Time.deltaTime;

        if (nowTime <= 0)
        {
            CreateShotObject(-transform.localEulerAngles.y);
            nowTime = time;
        }
    }

    private void CreateShotObject(float axis)
    {
        var direction = player.transform.position - transform.position;
        direction.y = 0;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        bulletObject.SetCharacterObject(gameObject);
        bulletObject.SetForwardAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
    }
}
