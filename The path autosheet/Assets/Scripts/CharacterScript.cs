using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    //Private Character Sheet Variables
    private string name;
    private AlignmentMap alignment;
    //Public Character Sheet 
    public enum AlignmentMap
    {
        LawfulEvil,
        ChaoticEvil,
        TrueEvil,
        LawfulNeutral,
        ChaoticNeutral,
        TrueNeutral,
        LawfulGood,
        ChaoticGood,
        TrueGood
    }
    public string CharacterName
    {
        get
        {
            return name;
        }

    }
    public string Alignment
    {
        get
        {
            return alignment.ToString();
        }
    }
    /// <summary>
    /// Initializes variables
    /// </summary>
    /// <param name="name">name of the character</param>
    /// <param name="alignment">alignment of the character</param>
    public void Init(string name, AlignmentMap alignment)
    {
        this.name = name;
        this.alignment = alignment;
    }
    /// <summary>
    /// Initializes empty variables
    /// </summary>
    public void Init()
    {
        this.name = "";
        this.alignment = AlignmentMap.TrueNeutral;
    }
    /// <summary>
    /// Changes alignment
    /// </summary>
    /// <param name="newAlignment">Changes alignent to this</param>
    public void ChangeAlignment(AlignmentMap newAlignment)
    {
        alignment = newAlignment;
    }
}
