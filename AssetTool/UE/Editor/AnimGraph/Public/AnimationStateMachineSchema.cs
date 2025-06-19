namespace AssetTool
{
    [JsonAsset("AnimationStateMachineSchema")]
    public class UAnimationStateMachineSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}