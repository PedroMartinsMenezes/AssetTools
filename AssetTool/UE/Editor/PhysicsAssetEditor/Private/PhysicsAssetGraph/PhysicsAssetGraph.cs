namespace AssetTool
{
    [JsonAsset("PhysicsAssetGraph")]
    public class UPhysicsAssetGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}