using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrashCounter : BaseCounter
{
    public static event EventHandler OnAnyObjectTrashed;

    // This clears any static event data so that it does not persist on Level reload
    // called in ResetStaticDataManager
    new public static void ResetStaticData() {
        OnAnyObjectTrashed = null;
    }

    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            player.GetKitchenObject().DestroySelf();

            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
    }
}
