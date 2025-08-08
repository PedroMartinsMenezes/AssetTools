namespace AssetTool
{
    [JsonAsset("AsyncNavWalkingMode")]
    public class UAsyncNavWalkingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}