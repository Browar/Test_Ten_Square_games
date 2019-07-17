using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    //public ScrollRect scrollView; //umożliwia szybki powrót do góry po wybraniu wędki kod w funkcji OnMouseDown
    public GameObject fishing_rod;//umożliwia ręczne dodanie wędki w unity bez zaglądania w kod
    public GameObject fishing_rod_shadow;
    private GameObject[] fishing_rods;
    private GameObject[] chooses;
    public GameObject choose;

    void Awake()
    {
        if (gameObject.tag == "clone")
        {
            SetRod();
        }
        //funckja która została stworzona aby wypełniać GameObjects jakim są 
        //fishing_rod oraz fishing_rod_shadow w prefab na potezeby skryptu CloneMaker tworzącego 
        //nowe okna z wędkami i generującego nowe rzędy tak aby można było skalować scrollwindow
    }
    
    void OnMouseDown()
    {
        OffRod();
        fishing_rod.SetActive(true);
        fishing_rod_shadow.SetActive(true);
        OffChoose();
        choose.SetActive(true);
        //scrollView.verticalNormalizedPosition = 1; //umożliwia szybki powrót do góry po wybraniu wędki
    }
    void OffRod()
    {
        fishing_rods = GameObject.FindGameObjectsWithTag("fishing_rod");
        foreach (GameObject rod in fishing_rods)
        {
            rod.SetActive(false);
        }
    }
    void OffChoose()
    {
        chooses = GameObject.FindGameObjectsWithTag("choose");
        foreach (GameObject choose in chooses)
        {
            choose.SetActive(false);
        }
    }
    void SetRod()
    {
        int rod_choose;
        //wędki wybierane losowo tylko dla klonów
        rod_choose = Random.Range(0, 2);
        if (rod_choose == 0)
        {
            fishing_rod = GameObject.Find("rod_spinning_prism");
            fishing_rod_shadow = GameObject.Find("rod_spinning_prism_shadow");
        }
        if ( rod_choose == 1)
        {
            fishing_rod = GameObject.Find("rod_spinning_twister");
            fishing_rod_shadow = GameObject.Find("rod_spinning_twister_shadow");
        }
    }
}
