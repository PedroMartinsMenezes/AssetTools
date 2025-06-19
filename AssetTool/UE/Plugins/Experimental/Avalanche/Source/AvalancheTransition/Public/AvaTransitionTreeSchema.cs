namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeSchema")]
    public class UAvaTransitionTreeSchema : UStateTreeSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}