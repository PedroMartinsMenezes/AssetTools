namespace AssetTool
{
    public class FNavAgentProperties : FMovementProperties
    {
        public float AgentRadius;
        public float AgentHeight;
        public float AgentStepHeight;
        public float NavWalkingSearchHeightScale;
        public FSoftObjectPath PreferredNavData;

        public const string StructName = "NavAgentProperties";

        public FNavAgentProperties() { }

        public FNavAgentProperties(BinaryReader reader)
        {
            AgentRadius = reader.ReadSingle();
            AgentHeight = reader.ReadSingle();
            AgentStepHeight = reader.ReadSingle();
            NavWalkingSearchHeightScale = reader.ReadSingle();
            reader.ReadValue(ref PreferredNavData, null);
        }

        public FNavAgentProperties(string s)
        {
            FNavAgentProperties obj = s.ToObject<FNavAgentProperties>();
            AgentRadius = obj.AgentRadius;
            AgentHeight = obj.AgentHeight;
            AgentStepHeight = obj.AgentStepHeight;
            NavWalkingSearchHeightScale = obj.NavWalkingSearchHeightScale;
            PreferredNavData = obj.PreferredNavData;
        }

        public override string ToString()
        {
            return this.ToJson();
        }

        public override void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(AgentRadius);
            writer.Write(AgentHeight);
            writer.Write(AgentStepHeight);
            writer.Write(NavWalkingSearchHeightScale);
            writer.WriteValue(PreferredNavData, null);
        }
    }

    public class FMovementProperties
    {
        public byte bCanCrouch;
        public byte bCanJump;
        public byte bCanWalk;
        public byte bCanSwim;
        public byte bCanFly;

        public FMovementProperties() { }

        public FMovementProperties(BinaryReader reader)
        {
            bCanCrouch = reader.ReadByte();
            bCanJump = reader.ReadByte();
            bCanWalk = reader.ReadByte();
            bCanSwim = reader.ReadByte();
            bCanFly = reader.ReadByte();
        }

        public FMovementProperties(string s)
        {
            FNavAgentProperties obj = s.ToObject<FNavAgentProperties>();
            bCanCrouch = obj.bCanCrouch;
            bCanJump = obj.bCanJump;
            bCanWalk = obj.bCanWalk;
            bCanSwim = obj.bCanSwim;
            bCanFly = obj.bCanFly;
        }

        public override string ToString()
        {
            return this.ToJson();
        }

        public virtual void Write(BinaryWriter writer)
        {
            writer.Write(bCanCrouch);
            writer.Write(bCanJump);
            writer.Write(bCanWalk);
            writer.Write(bCanSwim);
            writer.Write(bCanFly);
        }
    }
}
