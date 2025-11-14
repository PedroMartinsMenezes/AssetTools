namespace AssetTool
{
    [JsonAsset("AssetDefinition_DataprepAssetInterface")]
    public class UAssetDefinition_DataprepAssetInterface : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_DataprepAsset")]
    public class UAssetDefinition_DataprepAsset : UAssetDefinition_DataprepAssetInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_DataprepAssetInstance")]
    public class UAssetDefinition_DataprepAssetInstance : UAssetDefinition_DataprepAssetInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}