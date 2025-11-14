namespace AssetTool
{
    [JsonAsset("AssetDefinition_TouchInterface")]
    public class UAssetDefinition_TouchInterface : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}