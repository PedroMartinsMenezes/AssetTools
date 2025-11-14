namespace AssetTool
{
    [JsonAsset("PropertyAnimatorPresetRotation")]
    public class UPropertyAnimatorPresetRotation : UPropertyAnimatorCorePropertyPreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}