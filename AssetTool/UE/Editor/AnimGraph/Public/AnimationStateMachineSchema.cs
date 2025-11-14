namespace AssetTool
{
    [JsonAsset("AnimationStateMachineSchema")]
    public class UAnimationStateMachineSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}