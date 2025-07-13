namespace AssetTool
{
    [JsonAsset("PropertyAnimatorPresetLocation")]
    public class UPropertyAnimatorPresetLocation : UPropertyAnimatorCorePropertyPreset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}