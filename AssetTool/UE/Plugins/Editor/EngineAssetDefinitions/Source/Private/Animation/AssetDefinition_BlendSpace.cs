namespace AssetTool
{
    [JsonAsset("AssetDefinition_BlendSpace")]
    public class UAssetDefinition_BlendSpace : UAssetDefinition_AnimationAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}