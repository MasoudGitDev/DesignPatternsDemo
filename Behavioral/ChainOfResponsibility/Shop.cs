using ChainOfResponsibility.Abstractions;
using ChainOfResponsibility.CustomerHandlers;
using Shared.Services;

namespace ChainOfResponsibility;
internal class Shop{

    // Start with the seller that has the smallest number.
    // this was has handle next seller
    private static SortedList<byte ,ChainSellHandler> _sellers = new() {
        { 3 , new Owner() },
        { 1 , new Customer() },
        { 2 , new Manager() }        
    };


    public static void Sell(IFood food) {
        if(!IsShopOpen()) {
            Logger.Log("Sorry , Shop is closed.");
            return;
        }
        foreach(var seller in _sellers) {
            bool isSold = seller.Value.Sell(food);
            if (isSold) {
                break; 
            }
            else {
                continue;
            }
        }
    }

    private static bool IsShopOpen() {
        foreach(var seller in _sellers) {
            if(seller.Value.IsPresent) {
                return true;
            }
        }        
        return false;
    }

}
