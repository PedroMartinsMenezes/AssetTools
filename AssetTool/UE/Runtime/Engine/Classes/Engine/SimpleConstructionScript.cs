namespace AssetTool
{
    [JsonAsset("SimpleConstructionScript")]
    public class USimpleConstructionScript : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}