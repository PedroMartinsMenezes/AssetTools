namespace AssetTool
{
    [JsonAsset("AssetDefinition_PoseAsset")]
    public class UAssetDefinition_PoseAsset : UAssetDefinition_AnimationAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}