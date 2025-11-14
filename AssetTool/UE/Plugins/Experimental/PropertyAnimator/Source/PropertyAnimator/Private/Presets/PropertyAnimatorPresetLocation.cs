namespace AssetTool
{
    [JsonAsset("PropertyAnimatorPresetLocation")]
    public class UPropertyAnimatorPresetLocation : UPropertyAnimatorCorePropertyPreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}