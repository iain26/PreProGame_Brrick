using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restoration : MonoBehaviour {

    public delegate bool Renovate(GameObject building);
    public static event Renovate onClickCheckMoney;

    Color32 transpa = new Color32(255, 255, 255, 80);
    Color32 fullyVis = new Color32(255, 255, 255, 255);

    // Use this for initialization
    void Start () {
        GetComponent<Image>().color = transpa;
    }

    public void Restore()
    {
        GetComponent<Image>().color = fullyVis;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
