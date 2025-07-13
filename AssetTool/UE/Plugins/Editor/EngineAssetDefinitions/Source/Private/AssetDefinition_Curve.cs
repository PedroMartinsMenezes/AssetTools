namespace AssetTool
{
    [JsonAsset("AssetDefinition_Curve")]
    public class UAssetDefinition_Curve : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}