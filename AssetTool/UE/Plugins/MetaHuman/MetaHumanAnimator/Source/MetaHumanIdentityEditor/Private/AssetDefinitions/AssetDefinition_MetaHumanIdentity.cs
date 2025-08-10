namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaHumanIdentity")]
    public class UAssetDefinition_MetaHumanIdentity : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}