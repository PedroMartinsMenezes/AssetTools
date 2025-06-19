namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeFactory")]
    public class UAvaTransitionTreeFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}