using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();
        p1.InitializePlayer("HEMA", 100);
        p2.InitializePlayer("SAED", 50);
        p1.Heal(true);
        p2.Heal(true);
        Player.ShowPlayerCount();
    }

}
