namespace AssetTool
{
    [JsonAsset("PhysicsAssetGraph")]
    public class UPhysicsAssetGraph : UEdGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}