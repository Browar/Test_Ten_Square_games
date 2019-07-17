using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloneMaker : MonoBehaviour
{
    public ScrollRect scroll_view;
    public GameObject content;
    public GameObject prefab;
    public int clone_number=0;// liczba powieleń 3 rzędów wędek
    
    void Start()
    {
        for(int a=1;a<= clone_number; a++)
        {
            GenerateItem();
        }
        scroll_view.verticalNormalizedPosition = 1;
    }

    void GenerateItem()
    {
        GameObject scrollItemObj = Instantiate(prefab);
        scrollItemObj.transform.SetParent(content.transform, false);
    }
}
