
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject

{
    //the name of the item
    public string itemName;

    //the details of the item such as the name of the store, material composition ....
    public string descriptoin;

    //Icone Picture of the item
    public Sprite thumbnail;

    //3d Model of the item (having changes as children
    public GameObject theModel;

    //Social sustainability rank Array in life phases
    public int[] socialSustainabilityRank;

    //Social sustainability explanation string Array in life phases
    public string[] socialSustainabilityExplain;

    //Material sustainability rank Array in life phases
    public int[] materialSustainabilityRank;


    //Material sustainability explanation string Array in life phases
    public string[] materialSustainabilityExplain;

    //Donation rank Array in life phases
    public int[] donationRank;


    //Donation explanation string Array in life phases
   public string[] donationExplain;



}
