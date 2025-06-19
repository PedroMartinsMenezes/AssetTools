namespace AssetTool
{
    [JsonAsset("GridPathFollowingComponent")]
    public class UGridPathFollowingComponent : UPathFollowingComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}