namespace AssetTool
{
    [JsonAsset("PathFollowingComponent")]
    public class UPathFollowingComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}