namespace AssetTool
{
    [JsonAsset("NavMoverComponent")]
    public class UNavMoverComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}