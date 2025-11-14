namespace AssetTool
{
    [JsonAsset("PhysicsAssetGraphSchema")]
    public class UPhysicsAssetGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}