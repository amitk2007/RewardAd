﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class AdsScript : MonoBehaviour
{
    #if UNITY_IOS
        private string gameId = "1572402";
    #elif UNITY_ANDROID
        private string gameId = "1572401";
        #endif

    Button m_Button;

    public string placementId = "rewardedVideo";

    void Start()
    {
        m_Button = GetComponent<Button>();
        if (m_Button) m_Button.onClick.AddListener(ShowAd);
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, true);
        }

    }

    void Update()
    {
        if (m_Button) m_Button.interactable = Advertisement.IsReady(placementId);
    }
    private void OnMouseEnter()
    {
        if(Advertisement.IsReady(placementId))
        {
            ShowAd();
        }
    }
    void ShowAd()//reward
    {
        ShowOptions options = new ShowOptions();
        //options.resultCallback = HandleShowResult;

        Advertisement.Show(placementId, options);
    }

    /*void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video completed - Offer a reward to the player");

        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("Video was skipped - Do NOT reward the player");

        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video failed to show");
        }
    }*/
}