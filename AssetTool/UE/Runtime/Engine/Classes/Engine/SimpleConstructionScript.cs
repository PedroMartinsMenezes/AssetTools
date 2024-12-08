namespace AssetTool
{
    [JsonAsset("SimpleConstructionScript")]
    public class USimpleConstructionScript : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}