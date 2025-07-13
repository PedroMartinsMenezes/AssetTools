namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimMontage")]
    public class UAssetDefinition_AnimMontage : UAssetDefinition_AnimationAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}