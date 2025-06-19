namespace AssetTool
{
    [JsonAsset("ZipliningMode")]
    public class UZipliningMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}