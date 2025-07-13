namespace AssetTool
{
    [JsonAsset("AssetDefinition_SpecularProfile")]
    public class UAssetDefinition_SpecularProfile : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}