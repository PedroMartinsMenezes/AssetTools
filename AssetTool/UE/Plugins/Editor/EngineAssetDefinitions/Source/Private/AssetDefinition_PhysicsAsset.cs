namespace AssetTool
{
    [JsonAsset("AssetDefinition_PhysicsAsset")]
    public class UAssetDefinition_PhysicsAsset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}