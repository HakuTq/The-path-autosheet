using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CharacterTests
{
    private CharacterScript character;

    [SetUp]
    public void Init()
    {
        character = new CharacterScript("Test", "LE");
    }

    [Test]
    public void Alignment()
    {
        Assert.AreEqual("Lawful Evil", character.Alignment);
        //Assert.AreEqual("True Good", character.Alignment);
    }
}
