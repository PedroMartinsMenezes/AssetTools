namespace AssetTool
{
    [JsonAsset("WalkingMode")]
    public class UWalkingMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}