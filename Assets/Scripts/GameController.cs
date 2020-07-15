using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameController : MonoBehaviour
{
    [Header("Audios")]
    public AudioSource audioSource;
    public AudioClip clipAccept, clipError;
    public int scoreAccept, scoreError, randonNumber = 0;
    [Tooltip("Text of Score")]
    public TextMeshProUGUI textScoreAccept, textScoreError;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void PlayAccept()
    {
        audioSource.clip = clipAccept;
        audioSource.Play();
    }
    private void PlayError()
    {
        audioSource.clip = clipError;
        audioSource.Play();
    }
    void Randomize()
    {
        randonNumber = UnityEngine.Random.Range(0,2);
        Debug.Log(randonNumber);
    }

    public void Vote(int number)
    {
        if (number == randonNumber)
            Accept();
        else
            Error();
        Randomize();
        Debug.Log(randonNumber);
    }
    private void Accept()
    {
        PlayAccept();
        scoreAccept++;
        textScoreAccept.text = $"Sorte: {scoreAccept}";
    }
    private void Error()
    {
        PlayError();
        scoreError++;
        textScoreError.text = $"Azar: {scoreError}";

    }
}
