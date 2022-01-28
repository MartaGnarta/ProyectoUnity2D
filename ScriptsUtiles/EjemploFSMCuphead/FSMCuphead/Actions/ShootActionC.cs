using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Cuphead/Actions/Shoot")]
public class ShootActionC : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("Idle", false);
        //controller.SetAnimation("attack", false);
        controller.SetAnimation("Shot", true);
    }
}
