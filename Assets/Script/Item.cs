
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject

{
    //the name of the item
    [SerializeField] string itemName;

    //the details of the item such as the name of the store, material composition ....
    [SerializeField] string descriptoin;

    //Icone Picture of the item
    [SerializeField] Sprite thumbnail;

    //3d Model of the item (having changes as children
    [SerializeField] GameObject theModel;

    //Social sustainability rank Array in life phases
    [SerializeField] int[] socialSustainabilityRank;

    //Social sustainability explanation string Array in life phases
    [SerializeField] string[] socialSustainabilityExplain;

    //Material sustainability rank Array in life phases
    [SerializeField] int[] materialSustainabilityRank;


    //Material sustainability explanation string Array in life phases
    [SerializeField] string[] materialSustainabilityExplain;

    //Donation rank Array in life phases
    [SerializeField] int[] donationRank;


    //Donation explanation string Array in life phases
    [SerializeField] string[] donationExplain;



}
