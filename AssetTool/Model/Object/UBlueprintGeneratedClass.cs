namespace AssetTool
{
    using FEditorTags = Dictionary<FName, FString>;

    [JsonAsset("BlueprintGeneratedClass")]
    public class UBlueprintGeneratedClass : UClass
    {
        public FEditorTags CookedEditorTags;

        [Location("void UBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.BPGCCookedEditorTags && GlobalObjects.IsFilterEditorOnly())
            {
                transfer.Move(ref CookedEditorTags);
            }
            return this;
        }
    }
}