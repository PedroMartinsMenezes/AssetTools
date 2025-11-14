namespace AssetTool
{
    [JsonAsset("FollowSplineMode")]
    public class UFollowSplineMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}