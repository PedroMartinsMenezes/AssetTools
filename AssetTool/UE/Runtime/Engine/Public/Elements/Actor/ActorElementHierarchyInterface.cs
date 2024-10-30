namespace AssetTool
{
    [JsonAsset("ActorElementHierarchyInterface")]
    public class UActorElementHierarchyInterface : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}