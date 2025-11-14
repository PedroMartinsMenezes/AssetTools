namespace AssetTool
{
    [JsonAsset("PathFollowingComponent")]
    public class UPathFollowingComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}