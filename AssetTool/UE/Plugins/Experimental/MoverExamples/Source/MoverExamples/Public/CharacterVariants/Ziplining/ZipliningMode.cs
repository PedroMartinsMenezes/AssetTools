namespace AssetTool
{
    [JsonAsset("ZipliningMode")]
    public class UZipliningMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}