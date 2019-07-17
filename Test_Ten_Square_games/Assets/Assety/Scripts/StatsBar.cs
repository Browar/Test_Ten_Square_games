using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsBar : MonoBehaviour
{
    public Slider bar;
    private float progress;
    private float limit;

    void Start()
    {

        progress = Random.Range(1, 10);
        limit = 10;
        SetProgress();

    }
    void SetProgress()
    {
        bar.value = (progress / limit);
    }
}
