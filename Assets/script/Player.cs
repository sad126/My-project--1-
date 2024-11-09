using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    private string playerName;
    private int health;
    private static int countPlayer = 0;
    public void InitializePlayer(string name, int initialHealth){
        playerName = name;
        health = initialHealth;
        countPlayer++;
    }
    public void Heal(int amount){
        
        int new_health = amount +health;
        if(new_health > 100){
            Debug.Log("the health is full and is " + 10);
        }
        else{
        health = new_health;
        Debug.Log("the health is "+new_health);
        }
    }
    public void Heal(bool fullRestore) {
        if(fullRestore == true){
            health = 100;
            Debug.Log("the health is full to " + playerName + " and  health  is " + health);
        }
    }
    
    public static void ShowPlayerCount(){
        Debug.Log("the player count is " + countPlayer);
    }
    

}
