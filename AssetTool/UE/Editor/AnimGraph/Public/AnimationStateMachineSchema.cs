namespace AssetTool
{
    [JsonAsset("AnimationStateMachineSchema")]
    public class UAnimationStateMachineSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}