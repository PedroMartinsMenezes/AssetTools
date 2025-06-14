namespace AssetTool
{
    [JsonAsset("NullMovementMode")]
    public class UNullMovementMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovementModeStateMachine")]
    public class UMovementModeStateMachine : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImmediateMovementModeTransition")]
    public class UImmediateMovementModeTransition : UBaseMovementModeTransition
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}