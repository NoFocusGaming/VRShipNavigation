using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMgr : MonoBehaviour
{
    public static PlayerMgr inst;

    private void Awake()
    {
        inst = this;
    }

    private List<PlayerData> players = new List<PlayerData>();
    private int currPlayer = 0;
    private List<int> activePlayers = new List<int>();

    private string currShip;

    public int CurrPlayer { get; set; }
    public string PlayerName(int i) { return players[i].playerName; }
    public int MaxPlayers() {return players.Count; }
    public bool CanAddPlayer() {return activePlayers.Count < MaxPlayers(); }

    // called prior to the first frame update
    void Start()
    {
        PlayerData p = null;
        int numPlayers = 0;
        do
        {
            p = Resources.Load<PlayerData>("Players/player_" + numPlayers);

            if (p != null)
            {
                players.Add(p);
                if (p.playerName != "default")
                    activePlayers.Add(numPlayers);
            }
            numPlayers++;
        } while (p != null);
    }

    public bool AddPlayer(string playerName)
    {
        if (CanAddPlayer())
        {
            for (int i = 0; i < MaxPlayers(); i++)
            {
                if (!activePlayers.Contains(i))
                {
                    players[i].playerName = playerName;
                    activePlayers.Add(i);
                    return true;
                }
            }

            Debug.Log("Error: Unable to find unused PlayerData asset");
            return false;
        }
        else
        {
            Debug.Log("Error: Trying to add more players than allowed by current number of PlayerData asset");
            return false;
        }
    }

    public bool RemovePlayer(string playerName)
    {
        if(activePlayers.Count > 0)
        {
            for (int i = 0; i < MaxPlayers(); i++)
            {
                if (players[i].playerName == playerName)
                {
                    players[i].playerName = "default";
                    // reset any other PlayerData values to default
                    activePlayers.Remove(i);
                    return true;
                }
            }

            Debug.Log("Error: Could not find " + playerName + " when trying to removePlayer");
            return false;
        }
        else
        {
            Debug.Log("Error: Trying to remove player when there are no more active players");
            return false;
        }
    }
}
