using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownArrow : MonoBehaviour
{
    private bool up_or_down = false;
    public float speed = 1.0f;
    public Transform start, stop;// pozycje które można ustawić ręcznie na scenie bez zaglądania w kod

    void Update()
    {
        if (up_or_down)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        ChangeDirection();
    }

    void ChangeDirection()
    {
        if (transform.position.y <= stop.position.y)
        {
            up_or_down = true;
        }
        if (transform.position.y >= start.position.y)
        {
            up_or_down = false;
        }
    }
}

