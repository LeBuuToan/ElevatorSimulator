using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevatorController : MonoBehaviour
{
    private int floor = -1;

    // Update is called once per frame
    void Update()
    {

        if (floor == 0 && transform.position.y > 1)
        {
            if (transform.position.y == 1.005f)
                return;

            transform.Translate(0, -0.05f, 0);
        }

        if (floor == 1)
        {
            if (transform.position.y == 3.225f)
                return;

            if(transform.position.y < 3)
                transform.Translate(0, 0.05f, 0);
            else
                transform.Translate(0, -0.05f, 0);
        }

        if (floor == 2)
        {
            if (transform.position.y == 5.497f)
                return;

            if (transform.position.y < 5)
                transform.Translate(0, 0.05f, 0);
            else
                transform.Translate(0, -0.05f, 0);
        }

        if (floor == 3)
        {
            if (transform.position.y == 7.743f)
                return;

            if (transform.position.y < 7)
                transform.Translate(0, 0.05f, 0);
            else
                transform.Translate(0, -0.05f, 0);
        }

        if (floor == 4)
        {
            if (transform.position.y == 9.989f)
                return;

            if (transform.position.y < 9)
                transform.Translate(0, 0.05f, 0);
            else
                transform.Translate(0, -0.05f, 0);
        }

        if (floor == 5)
        {
            if (transform.position.y == 12.235f)
                return;

            if (transform.position.y < 12)
                transform.Translate(0, 0.05f, 0);
        }

        Debug.Log("Dang o tang" + floor);
    }

    public void CallButton0()
    {
        floor = 0;
        Debug.Log("Tang Tret");
    }

    public void CallButton1()
    {
        floor = 1;
        Debug.Log("Tang 1");
    }

    public void CallButton2()
    {
        floor = 2;
        Debug.Log("Tang 2");
    }

    public void CallButton3()
    {
        floor = 3;
        Debug.Log("Tang 3");
    }

    public void CallButton4()
    {
        floor = 4;
        Debug.Log("Tang 4");
    }

    public void CallButton5()
    {
        floor = 5;
        Debug.Log("Tang 5");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
