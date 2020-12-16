using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Manager : MonoBehaviour
{
    private static Manager instance;
    public static Manager Instance
    {
        get
        { if (instance == null)
                Debug.LogError("Assign the Manager");
            return instance;
        }
    }



    public Item arItem;

    public ItemBasePhase currentPhase ;

    public GameObject modelForItem;

    public readonly Phase00 phase00 = new Phase00();
    public readonly Phase01 phase01 = new Phase01();
    public readonly Phase02 phase02 = new Phase02();
    public readonly Phase03 phase03 = new Phase03();
    public readonly Phase04 phase04 = new Phase04();
    public readonly Phase05 phase05 = new Phase05();

    //All the components that will change during life phases

    public int currentSocialSustainabilityRank;
    public string currenetSocialSustainabilityExplain;

    public int currentMaterialSustainabilityRank;
    public string currentMaterialSustainabilityExplain;

    public int currentDonationRank;
    public string currentDonationExplain;

    public int useFrequency ;
    public float currentLifePhase;


    private void Awake()
    {
       instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
       
        TransitionToPhase(phase00);


    }

    // Update is called once per frame
    void Update()
    {

        MovingBetweenPhases();

        
    }


    void MovingBetweenPhases()
    {
        if (currentLifePhase >= 0 && currentLifePhase < 1)
        {
            TransitionToPhase(phase00);
        }

        else if (currentLifePhase >= 1 && currentLifePhase < 2)
        {
            TransitionToPhase(phase01);

        }

        else if (currentLifePhase >= 2 && currentLifePhase < 3)
        {
            TransitionToPhase(phase02);

        }

        else if (currentLifePhase >= 3 && currentLifePhase < 4)
        {
            TransitionToPhase(phase03);

        }

        else if (currentLifePhase >= 4 && currentLifePhase < 5)
        {
            TransitionToPhase(phase04);

        }
        else
        {
            TransitionToPhase(phase05);

        }

    }


        void TransitionToPhase(ItemBasePhase itemPhase)
    {
        currentPhase = itemPhase;
        currentPhase.EnteringPhase(this);

    }

    //-----------------------------------------------------
    //inputs:

    //for getting info from life phase slider
    public void SliderLifePhase(float LifePhase)
    {
        //int lifphasetoint = (int)Convert.ToUInt32(LifePhase);
        currentLifePhase = LifePhase;

    }


    //for getting info from use frequency
    public void SliderUseFrequency(float use)
    {
        int useFrequencytoint = (int)Convert.ToUInt32(use);
        useFrequency = useFrequencytoint;

    }


}
