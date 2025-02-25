﻿namespace AssetTool
{
    [JsonAsset("Class")]
    public class UClass : UStruct
    {
        public Dictionary<FName, TUInt32> FuncMap;
        public UInt32 ClassFlags;
        public UInt32 ClassWithin;
        public FName ClassConfigName;
        public Int32 NumInterfaces;
        public UInt32 ClassGeneratedBy;
        public List<FImplementedInterface> SerializedInterfaces;
        public FBool bDeprecatedForceScriptOrder;
        public FName Dummy;
        public FBool bCookedAsBool;
        public UInt32 PerspectiveNewCDO;

        [Location("void UClass::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref FuncMap);
            transfer.Move(ref ClassFlags);
            transfer.Move(ref ClassWithin);
            transfer.Move(ref ClassConfigName);

            long InterfacesStart = 0;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                InterfacesStart = transfer.Position;
                transfer.Move(ref NumInterfaces);
                transfer.Position = InterfacesStart + 4 + NumInterfaces * 12;
            }
            transfer.Move(ref ClassGeneratedBy);

            long CurrentOffset = transfer.Position;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                transfer.Position = InterfacesStart;
            }

            transfer.Move(ref SerializedInterfaces);

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                transfer.Position = CurrentOffset;
            }

            transfer.Move(ref bDeprecatedForceScriptOrder);
            transfer.Move(ref Dummy);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_COOKED_TO_UCLASS))
            {
                transfer.Move(ref bCookedAsBool);
            }

            transfer.Move(ref PerspectiveNewCDO);

            return this;
        }

        [Location("void UClass::SerializeDefaultObject(UObject* Object, FStructuredArchive::FSlot Slot)")]
        public virtual UObject SerializeDefaultObject(Transfer transfer)
        {
            SerializeTaggedProperties(transfer);
            return this;
        }

        [Location("void UStruct::SerializeTaggedProperties(FStructuredArchive::FSlot Slot, uint8* Data, UStruct* DefaultsStruct, uint8* Defaults, const UObject* BreakRecursionIfFullyLoad) const")]
        private void SerializeTaggedProperties(Transfer transfer)
        {
            SerializeVersionedTaggedProperties(transfer);
        }

        [Location("void UStruct::SerializeVersionedTaggedProperties(FStructuredArchive::FSlot Slot, uint8* Data, UStruct* DefaultsStruct, uint8* Defaults, const UObject* BreakRecursionIfFullyLoad) const")]
        private void SerializeVersionedTaggedProperties(Transfer transfer)
        {
            transfer.MoveTags(Tags, 0, this);
        }
    }
}
