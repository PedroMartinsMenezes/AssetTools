namespace AssetTool
{
    [JsonAsset("ActorElementHierarchyInterface")]
    public class UActorElementHierarchyInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}