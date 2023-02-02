using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHealth : StateMachineBehaviour
{
    [SerializeField] private string name = "";
    [SerializeField] private AIPlayer _player = null;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var manager = ServiceLocator.Get<AIPlayerManager>();

        _player = manager.GetPlayer(0);
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);


    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}
