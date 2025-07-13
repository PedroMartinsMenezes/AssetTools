namespace AssetTool
{
    [JsonAsset("AssetDefinition_ForceFeedbackEffect")]
    public class UAssetDefinition_ForceFeedbackEffect : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}