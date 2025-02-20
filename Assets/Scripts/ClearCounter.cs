using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClearCounter : BaseCounter
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            //there is a ktichen option here
            if (player.HasKitchenObject()) {
                //player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else { 
                //player not carrying anything    
            }
        } else {
            //there is a kitchenobject here
            if (player.HasKitchenObject()) {
                //he is carrying smthing
            } 
            else {
                GetKitchenObject().SetKitchenObjectParent(player); //doesnt carry anything
            }
        }
    }

    
}
