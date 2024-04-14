using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    //Character Sheet Variables
    private string _name;
    private string _alignment;
    //Alignment conversion vars
    private Dictionary<char, string> alignmentMap = new Dictionary<char, string>()
    {
        {'L', "Lawful"},
        {'C', "Chaotic"},
        {'T', "True"},
        {'E', "Evil"},
        {'N', "Neutral"},
        {'G', "Good"}
    };
    public string CharacterName
    {
        get
        {
            return _name;
        }

    }
    public string Alignment
    {
        get
        {
            string s = "";
            s += alignmentMap[_alignment[0]];
            s += " ";
            s += alignmentMap[_alignment[1]];
            return s;
        }
        set { _alignment = value; }
    }
    /// <summary>
    /// Creates new Instance; USE ONLY FOR TESTING
    /// </summary>
    /// <param name="name">name of the character</param>
    /// <param name="alignment">alignment of the charcter; Enter in two chars (LE = Lawful Evil)</param>
    public CharacterScript(string name, string alignment)
    {
        _name = name;
        _alignment = alignment;
    }

    public void ChangeAlignment(string newAlignment)
    {
        _alignment = newAlignment;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
