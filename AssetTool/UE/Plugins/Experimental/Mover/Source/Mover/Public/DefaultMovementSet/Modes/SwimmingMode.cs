namespace AssetTool
{
    [JsonAsset("SwimmingMode")]
    public class USwimmingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}