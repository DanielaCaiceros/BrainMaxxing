using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class rouletteTest
{
    [UnityTest]
    public IEnumerator Luck_5()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 0;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 5%", roulette.winText.text);
    }

    [UnityTest]
    public IEnumerator Luck_10()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 1;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 10%", roulette.winText.text);
    }

    [UnityTest]
    public IEnumerator Luck_12()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 2;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 12%", roulette.winText.text);
    }

    [UnityTest]
    public IEnumerator Luck_30()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 3;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 30%", roulette.winText.text);
    }

    [UnityTest]
    public IEnumerator Luck_43()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 4;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 43%", roulette.winText.text);
    }

    [UnityTest]
    public IEnumerator Luck_66()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 5;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 66%", roulette.winText.text);
    }

    [UnityTest]
    public IEnumerator Luck_70()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 6;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 70%", roulette.winText.text);
    }

    [UnityTest]
    public IEnumerator Luck_99()
    {
        //Arrange
        var roulette_object = new GameObject();
        var roulette = roulette_object.AddComponent<Wheel>();
        roulette.winText = new GameObject().AddComponent<UnityEngine.UI.Text>();

        //Act
        roulette.testOn = true;
        roulette.testAngle = 7;
        roulette.SetCoroutine_true();
        roulette.ForcedSpin();
        yield return new WaitForSeconds(roulette.GetTimeInterval());

        //Assert
        Assert.AreEqual("You Luck 99%", roulette.winText.text);
    }
}
