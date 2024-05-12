namespace AssetTool
{
    [Location("void UBlueprint::Serialize(FArchive& Ar)")]
    public class UBlueprint : UBlueprintCore
    {
        public const string TypeName = "Blueprint";

        public new UBlueprint Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
