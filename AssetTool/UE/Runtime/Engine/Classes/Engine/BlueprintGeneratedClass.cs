namespace AssetTool
{
    using FEditorTags = Dictionary<FName, FString>;

    [JsonAsset("BlueprintGeneratedClass")]
    public class UBlueprintGeneratedClass : UClass
    {
        public const string TypeName = "BlueprintGeneratedClass";

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

        [Location("void UBlueprintGeneratedClass::SerializeDefaultObject(UObject* Object, FStructuredArchive::FSlot Slot)")]
        public override UObject SerializeDefaultObject(Transfer transfer)
        {
            long expectedSize = GlobalObjects.CurrentObject.Size;
            long startPosition = transfer.Position;

            base.SerializeDefaultObject(transfer);

            if (Supports.SparseClassDataStructSerialization)
            {
                transfer.Move(ref Index);
                long actualSize = transfer.Position - startPosition;
                if (actualSize < expectedSize)
                {
                    if (Index.Index != 0)
                    {
                        SerializedSparseClassDataStruct ??= new();
                        SerializedSparseClassDataStruct.SerializeTaggedProperties(transfer);
                    }
                }
            }

            return this;
        }
    }
}