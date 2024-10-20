namespace AssetTool
{
    [JsonAsset("AnimSequenceBase")]
    public class UAnimSequenceBase : UAnimationAsset
    {
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}