namespace AssetTool
{
    [JsonAsset("AssetDefinition_ForceFeedbackAttenuation")]
    public class UAssetDefinition_ForceFeedbackAttenuation : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}