using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class AnswerSTest
{
    [UnityTest]
    public IEnumerator Correct_answer()
    {
        //Arrange
        var button_object = new GameObject();
        button_object.AddComponent<TextMeshProUGUI>();
        var button = button_object.AddComponent<UnityEngine.UI.Button>();

        var answer_object = new GameObject();
        var answer = answer_object.AddComponent<AnswerS>();

        answer.quizManager = new GameObject().AddComponent<QuizManager>();
        answer.quizManager.Panel = new GameObject();
        answer.quizManager.GoPanel = new GameObject();
        answer.quizManager.QuestionText = new GameObject().AddComponent<UnityEngine.UI.Text>();
        answer.quizManager.PlayerScoreText = new GameObject().AddComponent<UnityEngine.UI.Text>();
        answer.quizManager.ScoreText = new GameObject().AddComponent<UnityEngine.UI.Text>();
        answer.quizManager.options = new GameObject[1] { answer_object };
        answer.quizManager.Bots = new List<Bot>
        {
            new Bot("Bot1"),
            new Bot("Bot2")
        };
        answer.quizManager.BotScoreTexts = new Text[2] { new GameObject().AddComponent<UnityEngine.UI.Text>(), new GameObject().AddComponent<UnityEngine.UI.Text>() };
        button_object.transform.SetParent(answer_object.transform);

        answer.quizManager.SetQuestion(new QnA()
        {
            QuestionSetID = 1,
            QuestionID = 1,
            QuestionText = "What is the capital of France?",
            CorrectAnswer = "Paris",
            Choice1 = "Paris",
            Choice2 = "Berlin",
            Choice3 = "Madrid",
            Choice4 = "London"
        });
        answer.quizManager.SetQuestion(new QnA()
        {
            QuestionSetID = 1,
            QuestionID = 2,
            QuestionText = "What is the capital of Germany?",
            CorrectAnswer = "Berlin",
            Choice1 = "Berlin",
            Choice2 = "London",
            Choice3 = "Madrid",
            Choice4 = "Paris"
        });

        
        //Act
        button.onClick.AddListener(answer.Answer);
        button.onClick.Invoke();
        
        //Assert
        Assert.IsTrue(answer.isCorrect);
        yield return null;
    }

    [UnityTest]
    public IEnumerator Wrong_answer()
    {
        //Arrange
        var button_object = new GameObject();
        button_object.AddComponent<TextMeshProUGUI>();
        var button = button_object.AddComponent<UnityEngine.UI.Button>();

        var answer_object = new GameObject();
        var answer = answer_object.AddComponent<AnswerS>();

        answer.quizManager = new GameObject().AddComponent<QuizManager>();
        answer.quizManager.Panel = new GameObject();
        answer.quizManager.GoPanel = new GameObject();
        answer.quizManager.QuestionText = new GameObject().AddComponent<UnityEngine.UI.Text>();
        answer.quizManager.PlayerScoreText = new GameObject().AddComponent<UnityEngine.UI.Text>();
        answer.quizManager.ScoreText = new GameObject().AddComponent<UnityEngine.UI.Text>();
        answer.quizManager.options = new GameObject[1] { answer_object };
        answer.quizManager.Bots = new List<Bot>
        {
            new Bot("Bot1"),
            new Bot("Bot2")
        };
        answer.quizManager.BotScoreTexts = new Text[2] { new GameObject().AddComponent<UnityEngine.UI.Text>(), new GameObject().AddComponent<UnityEngine.UI.Text>() };
        button_object.transform.SetParent(answer_object.transform);

        answer.quizManager.SetQuestion(new QnA()
        {
            QuestionSetID = 1,
            QuestionID = 1,
            QuestionText = "What is the capital of France?",
            CorrectAnswer = "Paris",
            Choice1 = "Berlin",
            Choice2 = "Paris",
            Choice3 = "Madrid",
            Choice4 = "London"
        });
        answer.quizManager.SetQuestion(new QnA()
        {
            QuestionSetID = 1,
            QuestionID = 2,
            QuestionText = "What is the capital of Germany?",
            CorrectAnswer = "Berlin",
            Choice1 = "London",
            Choice2 = "Berlin",
            Choice3 = "Madrid",
            Choice4 = "Paris"
        });


        //Act
        button.onClick.AddListener(answer.Answer);
        button.onClick.Invoke();

        //Assert
        Assert.IsFalse(answer.isCorrect);
        yield return null;
    }
}
