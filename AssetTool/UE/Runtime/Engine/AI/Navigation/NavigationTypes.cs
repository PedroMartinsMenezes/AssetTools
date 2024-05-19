namespace AssetTool
{
    public class FNavAgentProperties : FMovementProperties
    {
        public const string StructName = "NavAgentProperties";

        public float AgentRadius;
        public float AgentHeight;
        public float AgentStepHeight;
        public float NavWalkingSearchHeightScale;
        public FSoftObjectPath PreferredNavData = new();

        public override FMovementProperties Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref AgentRadius);
            transfer.Move(ref AgentHeight);
            transfer.Move(ref AgentStepHeight);
            transfer.Move(ref NavWalkingSearchHeightScale);
            PreferredNavData.Move(transfer);
            return this;
        }

        public override string ToString()
        {
            return this.ToJson();
        }
    }

    public class FMovementProperties
    {
        public byte bCanCrouch;
        public byte bCanJump;
        public byte bCanWalk;
        public byte bCanSwim;
        public byte bCanFly;

        public virtual FMovementProperties Move(Transfer transfer)
        {
            transfer.Move(ref bCanCrouch);
            transfer.Move(ref bCanJump);
            transfer.Move(ref bCanWalk);
            transfer.Move(ref bCanSwim);
            transfer.Move(ref bCanFly);
            return this;
        }

        public override string ToString()
        {
            return this.ToJson();
        }
    }
}
