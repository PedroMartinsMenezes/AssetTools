namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeFactory")]
    public class UAvaTransitionTreeFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}