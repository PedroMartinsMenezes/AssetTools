namespace AssetTool
{
    [JsonAsset("AssetDefinition_World")]
    public class UAssetDefinition_World : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}