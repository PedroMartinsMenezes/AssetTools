namespace AssetTool
{
    [JsonAsset("PackFactory")]
    public class UPackFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}