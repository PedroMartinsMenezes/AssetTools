namespace AssetTool
{
    [JsonAsset("AnimationStateMachineGraph")]
    public class UAnimationStateMachineGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}