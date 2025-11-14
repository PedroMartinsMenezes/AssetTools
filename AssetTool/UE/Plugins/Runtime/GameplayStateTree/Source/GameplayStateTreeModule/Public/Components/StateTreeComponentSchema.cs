namespace AssetTool
{
    [JsonAsset("StateTreeComponentSchema")]
    public class UStateTreeComponentSchema : UStateTreeSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}