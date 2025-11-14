namespace AssetTool
{
    [JsonAsset("GroomFactory")]
    public class UGroomFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}