namespace AssetTool
{
    [JsonAsset("AsyncWalkingMode")]
    public class UAsyncWalkingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}