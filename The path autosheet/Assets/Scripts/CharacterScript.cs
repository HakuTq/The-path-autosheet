using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    //Private Character Sheet Variables
    private string name;
    private AlignmentMap alignment;
    private string race;
    private string deity;
    //Public Character Sheet 
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
    public string Race
    {
        get
        {
            return race;
        }
    }
    public string Deity
    {
        get
        {
            return deity;
        }
    }
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
    /// <summary>
    /// Initializes variables
    /// </summary>
    /// <param name="name">name of the character</param>
    /// <param name="alignment">alignment of the character</param>
    /// <param name="race">race of the character</param>
    /// <param name="deity">deity of the character</param>
    public void Init(string name, AlignmentMap alignment, string race, string deity)
    {
        this.name = name;
        this.alignment = alignment;
        this.race = race;
        this.deity = deity;
    }
    /// <summary>
    /// Initializes empty variables
    /// </summary>
    public void Init()
    {
        this.name = "";
        this.alignment = AlignmentMap.TrueNeutral;
        this.race = "Human";
        this.deity = "";
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
