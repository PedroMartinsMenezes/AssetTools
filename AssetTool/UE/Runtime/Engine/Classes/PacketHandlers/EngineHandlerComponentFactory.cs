namespace AssetTool
{
    [JsonAsset("EngineHandlerComponentFactory")]
    public class UEngineHandlerComponentFactory : UHandlerComponentFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}