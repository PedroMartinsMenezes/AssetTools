namespace AssetTool
{
    [JsonAsset("BaseMovementModeTransition")]
    public class UBaseMovementModeTransition : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}