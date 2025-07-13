namespace AssetTool
{
    [JsonAsset("AssetDefinition_Blueprint")]
    public class UAssetDefinition_Blueprint : UAssetDefinition_ClassTypeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}