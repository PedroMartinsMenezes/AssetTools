namespace AssetTool
{
    [JsonAsset("NavWalkingMode")]
    public class UNavWalkingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}