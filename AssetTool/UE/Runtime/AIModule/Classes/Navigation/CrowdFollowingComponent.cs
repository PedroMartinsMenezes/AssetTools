namespace AssetTool
{
    [JsonAsset("CrowdFollowingComponent")]
    public class UCrowdFollowingComponent : UPathFollowingComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}