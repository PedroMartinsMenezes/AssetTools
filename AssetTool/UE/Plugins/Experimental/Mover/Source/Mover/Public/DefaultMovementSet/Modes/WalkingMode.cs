namespace AssetTool
{
    [JsonAsset("WalkingMode")]
    public class UWalkingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}