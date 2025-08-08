namespace AssetTool
{
    [JsonAsset("AsyncWalkingMode")]
    public class UAsyncWalkingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}