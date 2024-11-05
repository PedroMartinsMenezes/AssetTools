namespace AssetTool
{
    [JsonAsset("Blueprint")]
    public class UBlueprint : UBlueprintCore
    {
        [Location("void UBlueprint::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Breakpoint")]
    public class UDEPRECATED_Breakpoint : UObject
    {
    }
}
