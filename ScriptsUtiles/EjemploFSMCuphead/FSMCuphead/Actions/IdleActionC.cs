using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Cuphead/Actions/Idle")]
public class IdleActionC : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Idle", true);
        //controller.SetAnimation("attack", false);
        controller.SetAnimation("Shot", false);
    }
}
