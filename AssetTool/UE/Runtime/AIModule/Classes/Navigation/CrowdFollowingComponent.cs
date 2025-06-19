namespace AssetTool
{
    [JsonAsset("CrowdFollowingComponent")]
    public class UCrowdFollowingComponent : UPathFollowingComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}