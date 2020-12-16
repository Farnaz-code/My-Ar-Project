using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InformationDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI itemTitle;
    [SerializeField] TextMeshProUGUI itemDetails;

    [SerializeField] TextMeshProUGUI socialCondition;
    [SerializeField] TextMeshProUGUI materialConsition;
    [SerializeField] TextMeshProUGUI donationCondition;

    [SerializeField] Image itemIcone;


    [SerializeField] GameObject gameobjectToRotate;

 




    // Start is called before the first frame update
    void Start()
    {
        itemTitle.text = Manager.Instance.arItem.itemName;
        itemDetails.text = Manager.Instance.arItem.descriptoin;
        itemIcone.sprite = Manager.Instance.arItem.thumbnail;
    }

    // Update is called once per frame
    void Update()
    {

        socialCondition.text = Manager.Instance.currenetSocialSustainabilityExplain;
        materialConsition.text = Manager.Instance.currentMaterialSustainabilityExplain;
        donationCondition.text = Manager.Instance.currentDonationExplain;
    }



    public void RotatingGameobjectRight()
    {
        Rotation(-1);
    }
    public void RotatingGameobjectLeft()
    {
        Rotation(1);
    }


    void Rotation(int direction)
    {
        LeanTween.rotateAroundLocal(gameobjectToRotate, Vector3.up, 30 * direction, 0.6f);
    }




}
