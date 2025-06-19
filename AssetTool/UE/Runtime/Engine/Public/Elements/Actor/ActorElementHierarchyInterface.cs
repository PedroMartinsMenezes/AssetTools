namespace AssetTool
{
    [JsonAsset("ActorElementHierarchyInterface")]
    public class UActorElementHierarchyInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}