namespace AssetTool
{
    [Location("void USimpleConstructionScript::Serialize(FArchive& Ar)")]
    public class USimpleConstructionScript : UObject
    {
        public const string TypeName = "SimpleConstructionScript";

        public new USimpleConstructionScript Move(Transfer transfer) => (USimpleConstructionScript)base.Move(transfer);
    }
}
