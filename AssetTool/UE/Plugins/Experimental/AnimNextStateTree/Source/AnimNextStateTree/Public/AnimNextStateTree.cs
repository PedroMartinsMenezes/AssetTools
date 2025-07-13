namespace AssetTool
{
    [JsonAsset("AnimNextStateTree")]
    public class UAnimNextStateTree : UAnimNextAnimationGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}