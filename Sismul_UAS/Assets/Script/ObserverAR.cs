using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverAR : DefaultObserverEventHandler
{
    private bool isFound;
    

    protected override void OnTrackingFound(){
        isFound = true;
        base.OnTrackingFound();
    }

    protected override void OnTrackingLost(){
        isFound = false;
        base.OnTrackingLost();
    }

    public bool getMarker(){
        return isFound;
    }
}