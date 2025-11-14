namespace AssetTool
{
    [JsonAsset("AnimationEditModeContext")]
    public class UAnimationEditModeContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}