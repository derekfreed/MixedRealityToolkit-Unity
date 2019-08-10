using Microsoft.MixedReality.Toolkit.Experimental.Utilities.Solvers;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using Microsoft.MixedReality.Toolkit.WindowsMixedReality.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandProjector : ControllerFinder
{
    public void ProjectHand(SliderEventData eventData)
    {
        foreach (var source in InputSystem.DetectedControllers)
        {
            if (source.InputSource.SourceType == InputSourceType.Hand)
            {
                WindowsMixedRealityArticulatedHand hand = (WindowsMixedRealityArticulatedHand)source;
                hand.HandOffset = eventData.NewValue;
            }
        }
    }
}
