using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    float fSatisfaction = 0.5f;
    float fMoney = 0.5f;
    float fPopulation = 0f;
    float fFood = 0.5f;

    Image satisfactionIm;
    Image moneyIm;
    Image populationIm;
    Image foodIm;

    public bool sampling = false;

    GameObject samplingObject;

	// Use this for initialization
	void Start () {
        IntialiseObjects();
    }

    private void OnEnable()
    {
        Selection.onSample += StatChange;
    }

    private void OnDisable()
    {
        Selection.onSample -= StatChange;
    }

    void StatChange(string stat, float change)
    {
        switch (stat)
        {
            case "Money":
                fMoney += change;
                break;
            case "Food":
                fFood += change;
                break;
            case "Population":
                fPopulation += change;
                break;
        }
    }

    void IntialiseObjects()
    {
        samplingObject = GameObject.Find("SamplingPanel");

        satisfactionIm = GameObject.Find("HappinessMeter").GetComponent<Image>();
        moneyIm = GameObject.Find("MoneyMeter").GetComponent<Image>();
        populationIm = GameObject.Find("PopulationMeter").GetComponent<Image>();
        foodIm = GameObject.Find("FoodMeter").GetComponent<Image>();
    }

    public void Sampling()
    {
        if (!sampling)
        {
            sampling = true;
        }
        else
        {
            sampling = false;
        }

    }

    void SetMeters()
    {
        satisfactionIm.fillAmount = fSatisfaction;
        moneyIm.fillAmount = fMoney;
        populationIm.fillAmount = fPopulation;
        foodIm.fillAmount = fFood;
    }
	
	// Update is called once per frame
	void Update ()
    {
        SetMeters();
        samplingObject.SetActive(sampling);
	}
}
