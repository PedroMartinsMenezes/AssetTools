namespace AssetTool
{
    [JsonAsset("PhysicsAssetGraphNode")]
    public class UPhysicsAssetGraphNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}