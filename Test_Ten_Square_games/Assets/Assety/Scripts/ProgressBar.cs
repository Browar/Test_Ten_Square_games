using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public GameObject arrow;
    public Slider bar;
    public Text progress_number;
    private float progress;
    private float limit;

    void Start()
    {

        progress = Random.Range(0, 100);
        limit = Random.Range(2, 60);
        SetProgress();
        CheckUpgrade();

    }
    void SetProgress()
    {
        bar.value = (progress / limit);
        progress_number.text = progress + "/" + limit;
    }
    //sprawdzenie czy można ulepszyć i wyświetlić strzałke
    void CheckUpgrade()
    {
        if(progress >= limit)
        {
            arrow.SetActive(true);
        }
        else
        {
            arrow.SetActive(false);
        }
    }
}
