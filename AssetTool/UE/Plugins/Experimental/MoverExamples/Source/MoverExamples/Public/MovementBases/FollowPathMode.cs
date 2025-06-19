namespace AssetTool
{
    [JsonAsset("FollowPathMode")]
    public class UFollowPathMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}