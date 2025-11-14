namespace AssetTool
{
    [JsonAsset("AsyncNavWalkingMode")]
    public class UAsyncNavWalkingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}