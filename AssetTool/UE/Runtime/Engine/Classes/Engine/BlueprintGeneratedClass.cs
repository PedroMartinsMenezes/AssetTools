namespace AssetTool
{
    using FEditorTags = Dictionary<FName, FString>;

    [JsonAsset("BlueprintGeneratedClass")]
    public class UBlueprintGeneratedClass : UClass
    {
        public const string TypeName = "BlueprintGeneratedClass";

        public FEditorTags CookedEditorTags;
        public WorkaroundPad WorkaroundPad;

        [Location("void UBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            if (transfer.GlobalObjects.CurrentObject.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                return SerializeDefaultObject(transfer);
            }
            else if (transfer.GlobalObjects.CurrentObject.SuperName is null)
            {
                return SerializeDefaultObject(transfer);
            }
            else
            {
                base.Move(transfer);
                if (transfer.Supports.BPGCCookedEditorTags && transfer.GlobalObjects.IsFilterEditorOnly())
                {
                    transfer.Move(ref CookedEditorTags);
                }
                return this;
            }
        }

        [Location("void UBlueprintGeneratedClass::SerializeDefaultObject(UObject* Object, FStructuredArchive::FSlot Slot)")]
        public override UObject SerializeDefaultObject(Transfer transfer)
        {
            base.SerializeDefaultObject(transfer);

            if (transfer.Supports.SparseClassDataStructSerialization)
            {
                transfer.Move(ref SparseClassDataStruct);
            }

            long remainingSize = transfer.GetRemainingSize();

            if (SparseClassDataStruct && remainingSize > 20)
            {
                SerializeSparseClassData(transfer);
            }
            else if ((WorkaroundPad = WorkaroundPad.CreateOrDefault(transfer, WorkaroundPad)) is { })
            {
                WorkaroundPad.Move(transfer);
            }

            return this;
        }


    }
}