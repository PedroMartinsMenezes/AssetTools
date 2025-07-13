namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimSequence")]
    public class UAssetDefinition_AnimSequence : UAssetDefinition_AnimationAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}