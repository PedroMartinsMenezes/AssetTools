namespace AssetTool
{
    [JsonAsset("GridPathFollowingComponent")]
    public class UGridPathFollowingComponent : UPathFollowingComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}