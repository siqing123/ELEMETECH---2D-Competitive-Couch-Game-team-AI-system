using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayerManager : MonoBehaviour
{
    public List<AIPlayer> _aiPlayers = new List<AIPlayer>();

    private void Awake()
    {
        ServiceLocator.Register<AIPlayerManager>(this);
    }

    public void AddAIPlayer(AIPlayer player)
    {
        _aiPlayers.Add(player);
    }

    public AIPlayer GetPlayer(int SpawnNodeIndex)
    {
        
        foreach(var player in _aiPlayers)
        {
            if (player.nodeIndex.Equals(SpawnNodeIndex))
            {
                return player;
            }
        }
        return null;
    }
}
