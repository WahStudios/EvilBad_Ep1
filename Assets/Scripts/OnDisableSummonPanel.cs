using UnityEngine;
using System.Collections;

public class OnDisableSummonPanel : MonoBehaviour {
    public GameObject summonSelect1;
    public GameObject summonSelect2;
    public GameObject summonSelect3;
    public GameObject summonSelect4;
    bool summonSelected1 = true;
    bool summonSelected2 = false;
    bool summonSelected3 = false;
    bool summonSelected4 = false;
    private bool axisInUse = false;
	// Use this for initialization

    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") < 0)// left
        {
            if (axisInUse == false)
            {
                axisInUse = true;
                if (summonSelected1 == true)
                {
                    summonSelected4 = true;
                    summonSelected1 = false;
                }
                else if (summonSelected2 == true)
                {
                    summonSelected1 = true;
                    summonSelected2 = false;
                }
                else if (summonSelected3 == true)
                {
                    summonSelected2 = true;
                    summonSelected3 = false;
                }
                else if (summonSelected4 == true)
                {
                    summonSelected3 = true;
                    summonSelected4 = false;
                }
                if (summonSelected1 == true)
                    summonSelect1.SetActive(true);
                else
                    summonSelect1.SetActive(false);
                if (summonSelected2 == true)
                    summonSelect2.SetActive(true);
                else
                    summonSelect2.SetActive(false);
                if (summonSelected3 == true)
                    summonSelect3.SetActive(true);
                else
                    summonSelect3.SetActive(false);
                if (summonSelected4 == true)
                    summonSelect4.SetActive(true);
                else
                    summonSelect4.SetActive(false);

            }
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)// right
        {
            if (axisInUse == false)
            {
                axisInUse = true;
                if (summonSelected1 == true)
                {
                    summonSelected2 = true;
                    summonSelected1 = false;
                }
                else if (summonSelected2 == true)
                {
                    summonSelected3 = true;
                    summonSelected2 = false;
                }
                else if (summonSelected3 == true)
                {
                    summonSelected4 = true;
                    summonSelected3 = false;
                }
                else if (summonSelected4 == true)
                {
                    summonSelected1 = true;
                    summonSelected4 = false;
                }
            }
            if (summonSelected1 == true)
                summonSelect1.SetActive(true);
            else
                summonSelect1.SetActive(false);
            if (summonSelected2 == true)
                summonSelect2.SetActive(true);
            else
                summonSelect2.SetActive(false);
            if (summonSelected3 == true)
                summonSelect3.SetActive(true);
            else
                summonSelect3.SetActive(false);
            if (summonSelected4 == true)
                summonSelect4.SetActive(true);
            else
                summonSelect4.SetActive(false);

        }
        else if(Input.GetAxis("Horizontal") == 0)
        {
            axisInUse = false;
            
        }
        

   


    }
	void OnDisable()
    {
        summonSelect1.SetActive(true);
        summonSelect2.SetActive(false);
        summonSelect3.SetActive(false);
        summonSelect4.SetActive(false);

    }
}
