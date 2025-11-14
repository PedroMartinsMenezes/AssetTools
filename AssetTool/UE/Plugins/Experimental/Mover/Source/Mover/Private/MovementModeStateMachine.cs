namespace AssetTool
{
    [JsonAsset("NullMovementMode")]
    public class UNullMovementMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImmediateMovementModeTransition")]
    public class UImmediateMovementModeTransition : UBaseMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}