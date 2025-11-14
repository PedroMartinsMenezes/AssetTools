namespace AssetTool
{
    [JsonAsset("StateTreeAIComponentSchema")]
    public class UStateTreeAIComponentSchema : UStateTreeComponentSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}