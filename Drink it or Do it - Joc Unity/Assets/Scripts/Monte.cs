using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Monte : MonoBehaviour, IUnityAdsListener 
{
    string GooglePlay_Id = "4158395";
    bool TestMode = false;
    string mySurfacingId="Rewarded_Android";
    void Start()
    {
        Advertisement.AddListener (this);
        Advertisement.Initialize(GooglePlay_Id,TestMode);
    }


    public void PlayAds(){
        Advertisement.Show(mySurfacingId);
    }
        public void ShowRewardedVideo() {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(mySurfacingId)) {
            Advertisement.Show(mySurfacingId);
        } 
        else {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish (string surfacingId, ShowResult showResult) {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            // Reward the user for watching the ad to completion.
        } else if (showResult == ShowResult.Skipped) {
            // Do not reward the user for skipping the ad.
        } else if (showResult == ShowResult.Failed) {
            
        }
    }

    public void OnUnityAdsReady (string surfacingId) {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        if (surfacingId == mySurfacingId) {
            // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError (string message) {
        // Log the error.
    }

    public void OnUnityAdsDidStart (string surfacingId) {
        // Optional actions to take when the end-users triggers an ad.
    } 

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy() {
        Advertisement.RemoveListener(this);
    }
}
