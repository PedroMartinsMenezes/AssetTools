namespace AssetTool
{
    [JsonAsset("PhysicsAssetGraphNode")]
    public class UPhysicsAssetGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}