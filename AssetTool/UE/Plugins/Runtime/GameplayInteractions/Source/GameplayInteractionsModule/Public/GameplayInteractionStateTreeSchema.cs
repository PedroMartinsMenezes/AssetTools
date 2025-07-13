namespace AssetTool
{
    [JsonAsset("GameplayInteractionStateTreeSchema")]
    public class UGameplayInteractionStateTreeSchema : UStateTreeSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}