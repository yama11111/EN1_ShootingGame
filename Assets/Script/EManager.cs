using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EManager : MonoBehaviour
{
    public int count;

    public Enemy e1;
    public Enemy e2;
    public Enemy e3;

    public Enemy e4;
    public Enemy e5;
    public Enemy e6;

    public Enemy e7;
    public Enemy e8;
    public Enemy e9;

    private int et1;
    private int et2;
    private int et3;

    private int et4;
    private int et5;
    private int et6;

    private int et7;
    private int et8;
    private int et9;

    // Start is called before the first frame update
    void Start()
    {
        et1 = 0;
        et2 = 0;
        et3 = 0;
        et4 = 0;
        et5 = 0;
        et6 = 0;
        et7 = 0;
        et8 = 0;
        et9 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (e1 == null) et1 = 1;
        if (e2 == null) et2 = 1;
        if (e3 == null) et3 = 1;
        if (e4 == null) et4 = 1;
        if (e5 == null) et5 = 1;
        if (e6 == null) et6 = 1;
        if (e7 == null) et7 = 1;
        if (e8 == null) et8 = 1;
        if (e9 == null) et9 = 1;

        count = et1 + et2 + et3 + et4 + et5 + et6 + et7 + et8 + et9;
    }
}
