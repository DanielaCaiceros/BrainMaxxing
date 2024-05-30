using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ConfidenceTest
{
    [UnityTest]
    public IEnumerator Succesful_APIDataSend()
    {
        //Arrange
        var confidence_object = new GameObject();
        confidence_object.AddComponent<Confidence>();
        var confidence = confidence_object.GetComponent<Confidence>();

        //Act
        confidence.OnButtonClicked(1);
        yield return null;

        //Assert
        Assert.Pass();
    }
}
