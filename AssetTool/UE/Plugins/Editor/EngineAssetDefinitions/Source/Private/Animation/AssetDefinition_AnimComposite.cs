namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimComposite")]
    public class UAssetDefinition_AnimComposite : UAssetDefinition_AnimationAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}