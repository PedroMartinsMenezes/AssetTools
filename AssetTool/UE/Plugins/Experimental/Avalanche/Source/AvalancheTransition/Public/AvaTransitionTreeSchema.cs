namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeSchema")]
    public class UAvaTransitionTreeSchema : UStateTreeSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}