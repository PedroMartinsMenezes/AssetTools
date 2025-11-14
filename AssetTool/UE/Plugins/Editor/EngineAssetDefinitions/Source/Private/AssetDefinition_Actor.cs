namespace AssetTool
{
    [JsonAsset("AssetDefinition_Actor")]
    public class UAssetDefinition_Actor : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}