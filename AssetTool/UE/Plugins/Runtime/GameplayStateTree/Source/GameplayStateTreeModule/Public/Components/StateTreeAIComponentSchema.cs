namespace AssetTool
{
    [JsonAsset("StateTreeAIComponentSchema")]
    public class UStateTreeAIComponentSchema : UStateTreeComponentSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}