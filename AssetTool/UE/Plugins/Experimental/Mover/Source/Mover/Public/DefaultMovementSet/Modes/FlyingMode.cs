namespace AssetTool
{
    [JsonAsset("FlyingMode")]
    public class UFlyingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}