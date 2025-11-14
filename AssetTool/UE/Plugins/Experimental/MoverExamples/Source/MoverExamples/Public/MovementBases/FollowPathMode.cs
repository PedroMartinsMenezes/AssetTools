namespace AssetTool
{
    [JsonAsset("FollowPathMode")]
    public class UFollowPathMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}