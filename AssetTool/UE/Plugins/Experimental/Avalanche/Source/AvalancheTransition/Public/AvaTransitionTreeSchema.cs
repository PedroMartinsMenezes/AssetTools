namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeSchema")]
    public class UAvaTransitionTreeSchema : UStateTreeSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}