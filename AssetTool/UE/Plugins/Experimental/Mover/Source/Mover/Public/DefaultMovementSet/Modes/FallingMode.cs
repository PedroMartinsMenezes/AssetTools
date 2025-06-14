namespace AssetTool
{
    [JsonAsset("FallingMode")]
    public class UFallingMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}