namespace AssetTool
{
    [JsonAsset("StateTreeTestSchema")]
    public class UStateTreeTestSchema : UStateTreeSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}