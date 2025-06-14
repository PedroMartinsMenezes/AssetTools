namespace AssetTool
{
    [JsonAsset("FlyingMode")]
    public class UFlyingMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}