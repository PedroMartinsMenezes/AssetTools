namespace AssetTool
{
    [JsonAsset("FollowPathMode")]
    public class UFollowPathMode : UBaseMovementMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}