namespace AssetTool
{
    [JsonAsset("TouchInterfaceFactory")]
    public class UTouchInterfaceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}