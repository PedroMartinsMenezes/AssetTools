namespace AssetTool
{
    [JsonAsset("FollowSplineMode")]
    public class UFollowSplineMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}