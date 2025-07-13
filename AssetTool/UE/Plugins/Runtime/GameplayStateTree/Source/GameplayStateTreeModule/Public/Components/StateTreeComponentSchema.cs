namespace AssetTool
{
    [JsonAsset("StateTreeComponentSchema")]
    public class UStateTreeComponentSchema : UStateTreeSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}