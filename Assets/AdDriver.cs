using UnityEngine;
using System.Collections;

using Heyzap;

// Click a button, and use this script to show an ad

public class AdDriver : MonoBehaviour 
{
    public void ShowAd(string placementName)
    {
        AdCentral.ShowAd(placementName);
    }

    public void ShowMediationSetup()
    {
        HeyzapAds.ShowMediationTestSuite();
    }
}
