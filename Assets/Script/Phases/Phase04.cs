using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase04 : ItemBasePhase
{
    //Item at almost the end of its life



    public override void Update(Manager sceneManager)
    {
        ChangingVariables(sceneManager);

        ChangingModel(sceneManager);
    }




    private void ChangingVariables(Manager sceneManager)
    {
        sceneManager.currentSocialSustainabilityRank = sceneManager.arItem.socialSustainabilityRank[4];
        sceneManager.currenetSocialSustainabilityExplain = sceneManager.arItem.socialSustainabilityExplain[4];

        sceneManager.currentMaterialSustainabilityRank = sceneManager.arItem.materialSustainabilityRank[4];
        sceneManager.currentMaterialSustainabilityExplain = sceneManager.arItem.materialSustainabilityExplain[4];

        sceneManager.currentDonationRank = sceneManager.arItem.donationRank[4];
        sceneManager.currentDonationExplain = sceneManager.arItem.donationExplain[4];
    }


    private void ChangingModel(Manager sceneManager)
    {
        if (sceneManager.arItem.theModel.transform.childCount > 0)
        {



            if (sceneManager.currentLifePhase >= 4 && sceneManager.currentLifePhase > 5)
            {

                switch (sceneManager.useFrequency)
                {
                    case 0: //weekly wash
                        sceneManager.arItem.theModel.transform.GetChild(0).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(1).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(2).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(3).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(4).gameObject.SetActive(true);
                        sceneManager.arItem.theModel.transform.GetChild(5).gameObject.SetActive(false);

                        break;
                    case 1: //monthly wash
                        sceneManager.arItem.theModel.transform.GetChild(0).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(1).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(2).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(3).gameObject.SetActive(true);
                        sceneManager.arItem.theModel.transform.GetChild(4).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(5).gameObject.SetActive(false);
                        break;
                    case 2: //ocassionally
                        sceneManager.arItem.theModel.transform.GetChild(0).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(1).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(2).gameObject.SetActive(true);
                        sceneManager.arItem.theModel.transform.GetChild(3).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(4).gameObject.SetActive(false);
                        sceneManager.arItem.theModel.transform.GetChild(5).gameObject.SetActive(false);
                        break;
                }

            }
        }
    }
}
