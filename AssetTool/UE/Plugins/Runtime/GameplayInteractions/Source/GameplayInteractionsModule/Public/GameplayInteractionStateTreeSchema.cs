namespace AssetTool
{
    [JsonAsset("GameplayInteractionStateTreeSchema")]
    public class UGameplayInteractionStateTreeSchema : UStateTreeSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}