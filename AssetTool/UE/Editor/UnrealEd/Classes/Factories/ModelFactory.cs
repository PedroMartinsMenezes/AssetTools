namespace AssetTool
{
    [JsonAsset("ModelFactory")]
    public class UModelFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}