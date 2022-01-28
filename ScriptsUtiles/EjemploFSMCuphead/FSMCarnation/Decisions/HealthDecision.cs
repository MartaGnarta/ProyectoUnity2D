using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Carnation/Decisions/HealthDecision")]
public class HealthDecision : FSM.Decision
{
    public int healthlimitmin, healthlimitmax;
    public override bool Decide(Controller controller)
    {
        int h = controller.GetCurrentHealth();
        bool t = (h < healthlimitmin && h < healthlimitmax);

        return t;
    }
}