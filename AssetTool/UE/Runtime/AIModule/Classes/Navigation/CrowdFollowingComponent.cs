namespace AssetTool
{
    [JsonAsset("CrowdFollowingComponent")]
    public class UCrowdFollowingComponent : UPathFollowingComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}