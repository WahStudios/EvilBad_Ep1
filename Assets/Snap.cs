using UnityEngine;
using System.Collections;

public class Snap : MonoBehaviour {

    public GameObject snapMenu;
	// Use this for initialization
	void OnEnable()
    {
        snapMenu.SetActive(true);
    }

    void OnDisable()
    {
        snapMenu.SetActive(false);
    }
}
