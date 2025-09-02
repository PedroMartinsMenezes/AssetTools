namespace AssetTool
{
    using FEditorTags = Dictionary<FName, FString>;

    [JsonAsset("BlueprintGeneratedClass")]
    public class UBlueprintGeneratedClass : UClass
    {
        public const string TypeName = "BlueprintGeneratedClass";

        public FEditorTags CookedEditorTags;
        public WorkaroundPad WorkaroundPad;
        public Data_60 Data60;

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

            #region Workaround Data (only when SparseClassDataStruct is not zero)
            long remainingSize = transfer.GetRemainingSize();

            if (remainingSize == 4) //@@@ hardcoded guess
            {
                transfer.Position += 4;
            }
            else if (remainingSize == 8) //@@@ hardcoded guess
            {
                SerializeSparseClassData(transfer);
            }
            else if (remainingSize == 60) //@@@ hardcoded guess
            {
                transfer.Move(ref Data60);
            }
            else if (SparseClassDataStruct && remainingSize > 20) //@@@ hardcoded guess
            {
                SerializeSparseClassData(transfer);
            }
            else if ((WorkaroundPad = WorkaroundPad.CreateOrDefault(transfer, WorkaroundPad, transfer.GlobalObjects.CurrentObject.NextOffset)) is { }) //@@@ no guess
            {
                WorkaroundPad.Move(transfer);
            }
            #endregion

            return this;
        }

        #region Workaround Data
        public class Data_60 : ITransferible
        {
            public List<Entry> Items;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref Items);
                return this;
            }

            public class Entry : ITransferible
            {
                public FPackageIndex Index;
                public FName Name;
                public FGuid Guid;

                public ITransferible Move(Transfer transfer)
                {
                    transfer.Move(ref Index);
                    transfer.Move(ref Name);
                    transfer.Move(ref Guid);
                    return this;
                }
            }
        }
        #endregion
    }
}