namespace AssetTool
{
    [JsonAsset("AssetDefinition_AvaTransitionTree")]
    public class UAssetDefinition_AvaTransitionTree : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}