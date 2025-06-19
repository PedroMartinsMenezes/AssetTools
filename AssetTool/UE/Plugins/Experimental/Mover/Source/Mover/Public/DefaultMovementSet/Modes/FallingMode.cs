namespace AssetTool
{
    [JsonAsset("FallingMode")]
    public class UFallingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}