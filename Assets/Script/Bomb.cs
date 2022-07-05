using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public GameObject particle;

    public int remain = 3;
    public Text remainText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        remainText.text = "BOMB : " + remain;

        if (Input.GetKeyDown(KeyCode.B) && remain > 0)
        {
            GameObject[] enemyBulletObjects =
                GameObject.FindGameObjectsWithTag("EnemyBullet");

            for (int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i].gameObject);
            }

            Instantiate(particle, Vector3.zero, Quaternion.identity);

            remain--;
        }
    }
}
