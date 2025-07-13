namespace AssetTool
{
    [JsonAsset("AssetDefinition_PhysicsAsset")]
    public class UAssetDefinition_PhysicsAsset : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}