namespace AssetTool
{
    [JsonAsset("NavMoverComponent")]
    public class UNavMoverComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}