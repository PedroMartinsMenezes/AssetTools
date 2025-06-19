namespace AssetTool
{
    [JsonAsset("HandlerComponentFactory")]
    public class UHandlerComponentFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}