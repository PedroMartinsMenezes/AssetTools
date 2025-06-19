namespace AssetTool
{
    [JsonAsset("PathFollowingComponent")]
    public class UPathFollowingComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}