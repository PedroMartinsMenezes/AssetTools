namespace AssetTool
{
    [JsonAsset("GridPathFollowingComponent")]
    public class UGridPathFollowingComponent : UPathFollowingComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}