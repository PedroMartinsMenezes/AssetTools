namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimComposite")]
    public class UAssetDefinition_AnimComposite : UAssetDefinition_AnimationAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}