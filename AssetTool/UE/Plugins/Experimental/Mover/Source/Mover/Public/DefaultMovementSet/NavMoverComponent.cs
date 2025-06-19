namespace AssetTool
{
    [JsonAsset("NavMoverComponent")]
    public class UNavMoverComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}