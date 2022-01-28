using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Cuphead/Decisions/AttackDecision")]
public class AttackDecision : FSM.Decision
{
    public override bool Decide(Controller controller)
    {
        return true;
    }
}