namespace AssetTool
{
    [JsonAsset("AvaRundownFactory")]
    public class UAvaRundownFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}