namespace AssetTool
{
    [JsonAsset("AssetDefinition_Redirector")]
    public class UAssetDefinition_Redirector : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}