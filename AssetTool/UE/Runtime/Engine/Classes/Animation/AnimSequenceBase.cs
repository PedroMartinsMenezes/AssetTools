namespace AssetTool
{
    public class UAnimSequenceBase : UAnimationAsset
    {
        public new const string TypeName = "AnimSequenceBase";

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}