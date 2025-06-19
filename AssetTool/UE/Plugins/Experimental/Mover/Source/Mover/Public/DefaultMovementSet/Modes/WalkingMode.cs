namespace AssetTool
{
    [JsonAsset("WalkingMode")]
    public class UWalkingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}