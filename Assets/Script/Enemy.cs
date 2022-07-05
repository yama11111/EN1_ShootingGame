using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHp = 3;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void Damage()
    {
        enemyHp = enemyHp - 1;
        Debug.Log(enemyHp);
        audioSource.Play();
    }
}
