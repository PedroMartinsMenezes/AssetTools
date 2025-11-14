namespace AssetTool
{
    [JsonAsset("SwimmingMode")]
    public class USwimmingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}