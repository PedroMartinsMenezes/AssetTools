namespace AssetTool
{
    [JsonAsset("BaseMovementMode")]
    public class UBaseMovementMode : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}