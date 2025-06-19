namespace AssetTool
{
    [JsonAsset("BaseMovementMode")]
    public class UBaseMovementMode : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}