namespace AssetTool
{
    [JsonAsset("PhysicsAssetGraphSchema")]
    public class UPhysicsAssetGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}