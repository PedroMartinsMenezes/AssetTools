namespace AssetTool
{
    [JsonAsset("GroomBindingFactory")]
    public class UGroomBindingFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}