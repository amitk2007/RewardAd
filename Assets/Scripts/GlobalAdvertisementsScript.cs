using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GlobalAdvertisementsScript : MonoBehaviour
{
#if UNITY_IOS
        private string gameId = "1572402";
#elif UNITY_ANDROID
    private string gameId = "1572401";
#endif

    public static string placementId = "rewardedVideo";

    // Use this for initialization
    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (m_Button) m_Button.interactable = Advertisement.IsReady(placementId);

    }

    public static void GlobalAdsShow(bool isReward)
    {
        if (isReward)
        {
            if (Advertisement.IsReady(placementId))
            {
                ShowAd();
            }
        }
        else
        {
            if (Advertisement.IsReady(placementId))
            {
                Advertisement.Show();
            }
        }

    }

    public static void ShowAd()//reward
    {
        ShowOptions options = new ShowOptions();
        //options.resultCallback = HandleShowResult;

        Advertisement.Show(placementId, options);
    }

    /*public static void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video completed - Offer a reward to the player");
            PlayerScript.AddPoints(1);
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
