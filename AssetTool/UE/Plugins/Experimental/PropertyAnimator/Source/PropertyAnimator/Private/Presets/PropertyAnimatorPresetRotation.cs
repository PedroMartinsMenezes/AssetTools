namespace AssetTool
{
    [JsonAsset("PropertyAnimatorPresetRotation")]
    public class UPropertyAnimatorPresetRotation : UPropertyAnimatorCorePropertyPreset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}