using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runAway : StateMachineBehaviour
{
    [SerializeField] private string name = "";
    [SerializeField] private AIPlayer _player = null;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        //var manager = ServiceLocator.Get<AIPlayerManager>();
        //_player = manager.GetPlayer(0);

        _player = animator.gameObject.GetComponent<AIPlayer>();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);
        
       
        _player.IsPlayerNearby();
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}