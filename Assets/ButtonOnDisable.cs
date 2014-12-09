using UnityEngine;
using System.Collections;

public class ButtonOnDisable : MonoBehaviour {
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
	// Use this for initialization
	void OnDisable()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }
}
