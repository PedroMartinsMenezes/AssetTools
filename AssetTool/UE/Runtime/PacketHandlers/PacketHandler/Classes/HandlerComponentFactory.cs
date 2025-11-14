namespace AssetTool
{
    [JsonAsset("HandlerComponentFactory")]
    public class UHandlerComponentFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}