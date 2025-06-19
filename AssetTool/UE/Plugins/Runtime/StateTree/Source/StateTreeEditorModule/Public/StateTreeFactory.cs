namespace AssetTool
{
    [JsonAsset("StateTreeFactory")]
    public class UStateTreeFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}