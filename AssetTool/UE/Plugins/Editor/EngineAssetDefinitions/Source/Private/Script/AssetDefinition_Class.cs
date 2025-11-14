namespace AssetTool
{
    [JsonAsset("AssetDefinition_Class")]
    public class UAssetDefinition_Class : UAssetDefinition_ClassTypeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}