namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimationAsset")]
    public class UAssetDefinition_AnimationAsset : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}