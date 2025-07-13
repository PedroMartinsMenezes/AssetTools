namespace AssetTool
{
    [JsonAsset("AssetDefinition_CameraAnimationSequence")]
    public class UAssetDefinition_CameraAnimationSequence : UAssetDefinition_TemplateSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}