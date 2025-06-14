namespace AssetTool
{
    [JsonAsset("SwimmingMode")]
    public class USwimmingMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}