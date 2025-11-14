namespace AssetTool
{
    [JsonAsset("NavWalkingMode")]
    public class UNavWalkingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}