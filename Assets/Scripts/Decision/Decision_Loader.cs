using System;
using UnityEngine;
using TMPro;
public class Decision_Loader : MonoBehaviour
{
    //!We've decided to make a "setter" class for setting current Decision string.
    //!By doing it this way, we can ensure that there is no conflict between several class objects.
    private readonly reciever reciever = reciever.Reciever;
    public TextMeshProUGUI ans1;
    public TextMeshProUGUI ans2;
    public TextMeshProUGUI ans3;
    public TextMeshProUGUI ans4;

    private void Start()
    {
        LoadintoObjects(1); //!Load the first set into the answer Objects, only do this once!.
    }


    // Use OnMouseDown instead of Update
    public void LoadintoObjects(int start)
    {
        //!Load the new set of decisions into the Objects, this can be done since we always give 4 defined decisions as an option
        //! We do this in this class since an easy access to all Objects can be granted
        ans1.text = reciever.GetDecision(start).getdecisionDescription();
        ans2.text = reciever.GetDecision(start+1).getdecisionDescription();
        ans3.text = reciever.GetDecision(start+2).getdecisionDescription();
        ans4.text = reciever.GetDecision(start+3).getdecisionDescription();

    }

    
}