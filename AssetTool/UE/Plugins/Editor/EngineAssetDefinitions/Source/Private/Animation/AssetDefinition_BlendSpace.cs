namespace AssetTool
{
    [JsonAsset("AssetDefinition_BlendSpace")]
    public class UAssetDefinition_BlendSpace : UAssetDefinition_AnimationAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}