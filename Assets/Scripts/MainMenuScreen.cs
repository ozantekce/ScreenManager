using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MainMenuScreen : Screen
{

    public GameObject logo;
    public Vector2 logoStartSize;
    public Vector2 logoEndSize;

    public Button playButton;
    public Vector2 playButtonStartPos;
    public Vector2 playButtonEndPos;

    public Button settingsButton;
    public Vector2 settingsButtonStartPos;
    public Vector2 settingsButtonEndPos;


    public Button quitButton;
    public Vector2 quitButtonStartPos;
    public Vector2 quitButtonEndPos;


    private Sequence openingSequence;
    private Sequence closeSequence;


    private RectTransform rectTransform;

    private void Awake()
    {

        rectTransform = GetComponent<RectTransform>();

        openingSequence = DOTween.Sequence();
        CreateOpeningSequence();



    }

    private void CreateOpeningSequence()
    {

        openingSequence.Join(playButton.GetComponent<RectTransform>()
            .DOAnchorPos(playButtonEndPos, 1.5f).SetEase(Ease.OutBounce));

        openingSequence.Join(settingsButton.GetComponent<RectTransform>()
            .DOAnchorPos(settingsButtonEndPos, 1.5f).SetEase(Ease.OutBounce));

        openingSequence.Join(quitButton.GetComponent<RectTransform>()
            .DOAnchorPos(quitButtonEndPos, 1.5f).SetEase(Ease.OutBounce));


        openingSequence.Append(logo.GetComponent<RectTransform>().DOSizeDelta(logoEndSize, 1.25f).SetEase(Ease.OutBounce));

        openingSequence.OnStart(delegate 
            {
                Debug.Log("1");
                playButton.enabled = false;
                settingsButton.enabled = false;
                quitButton.enabled = false;
                playButton.GetComponent<RectTransform>().anchoredPosition = playButtonStartPos;
                settingsButton.GetComponent<RectTransform>().anchoredPosition = settingsButtonStartPos;
                quitButton.GetComponent<RectTransform>().anchoredPosition = quitButtonStartPos;
                logo.GetComponent<RectTransform>().sizeDelta = logoStartSize;
            }
        );

        openingSequence.OnComplete(delegate {

            Debug.Log("2");
            playButton.enabled = true;
            settingsButton.enabled = true;
            quitButton.enabled = true;
            Opened = true;
        }
        );

        openingSequence.SetAutoKill(false);

    }


    public override void Close()
    {
        gameObject.SetActive(false);
        Opened = false;
    }

    public override void Open()
    {

        gameObject.SetActive(true);
        openingSequence.Restart();

    }



}
