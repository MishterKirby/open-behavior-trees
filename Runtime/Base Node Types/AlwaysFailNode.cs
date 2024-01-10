using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenBehaviorTrees
{
    public class AlwaysFailNode : DecoratorNode
    {
        protected override BehaviorTreeNodeResult Evaluate(BehaviorTree behaviorTree)
        {
            child.Tick(behaviorTree);
            return BehaviorTreeNodeResult.failure;
        }


        public override BehaviorTreeNode Clone()
        {
            AlwaysFailNode node = ScriptableObject.Instantiate(this);
            node.name = node.name.Replace("(Clone)", "").Trim();
            node.child = child.Clone();
            return node;
        }
    }
}


