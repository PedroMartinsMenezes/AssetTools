namespace AssetTool
{
    [JsonAsset("AssetDefinition_ClassTypeBase")]
    public class UAssetDefinition_ClassTypeBase : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}