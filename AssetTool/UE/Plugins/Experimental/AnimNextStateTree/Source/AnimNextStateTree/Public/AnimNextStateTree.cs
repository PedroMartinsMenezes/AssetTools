namespace AssetTool
{
    [JsonAsset("AnimNextStateTree")]
    public class UAnimNextStateTree : UAnimNextAnimationGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}