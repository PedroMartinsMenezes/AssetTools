namespace AssetTool
{
    [JsonAsset("EngineHandlerComponentFactory")]
    public class UEngineHandlerComponentFactory : UHandlerComponentFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}