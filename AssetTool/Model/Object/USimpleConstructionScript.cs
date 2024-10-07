namespace AssetTool
{
    [JsonAsset("SimpleConstructionScript")]
    public class USimpleConstructionScript : UObject
    {
        [Location("void USimpleConstructionScript::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
