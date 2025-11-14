namespace AssetTool
{
    [JsonAsset("SimpleConstructionScript")]
    public class USimpleConstructionScript : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}