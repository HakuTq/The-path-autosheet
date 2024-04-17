using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CharacterTests
{
    private CharacterScript character;
    private GameObject go;

    [SetUp]
    public void Init()
    {
        go = new GameObject();
        character = go.AddComponent<CharacterScript>();
    }

    [Test]
    public void ChangingAlignmentWorks()
    {
        //Arrange
        character.Init("Test", CharacterScript.AlignmentMap.LawfulEvil);
        //Act
        character.ChangeAlignment(CharacterScript.AlignmentMap.TrueGood);
        //Assert
        Assert.AreEqual("TrueGood", character.Alignment);
    }
}
