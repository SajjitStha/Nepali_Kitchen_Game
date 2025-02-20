using UnityEngine;
using System;

public class ContainerCounter : BaseCounter {
    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact(Player player) {
     if (!player.HasKitchenObject()) {
            //polayer is not carrying anything in hand
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
            
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }


    }
}
    

