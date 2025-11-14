namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimMontage")]
    public class UAssetDefinition_AnimMontage : UAssetDefinition_AnimationAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}