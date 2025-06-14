namespace AssetTool
{
    [JsonAsset("NavWalkingMode")]
    public class UNavWalkingMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}