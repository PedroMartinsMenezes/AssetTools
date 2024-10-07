namespace AssetTool
{
    [JsonAsset("Class")]
    public class UClass : UStruct
    {
        public Dictionary<FName, TUInt32> FuncMap = new();
        public UInt32 ClassFlags;
        public UInt32 ClassWithin;
        public FName ClassConfigName = new();
        public Int32 NumInterfaces;
        public UInt32 ClassGeneratedBy;
        public List<FImplementedInterface> SerializedInterfaces = [];
        public FBool bDeprecatedForceScriptOrder;
        public FName Dummy = new();
        public FBool bCookedAsBool = new();
        public UInt32 PerspectiveNewCDO;

        [Location("void UClass::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            FuncMap.Resize(transfer);
            foreach (var pair in FuncMap)
            {
                transfer.Move(pair.Key);
                pair.Value.Move(transfer);
            }

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

            SerializedInterfaces.Resize(transfer);
            SerializedInterfaces.ForEach(x => x.Move(transfer));

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
    }
}
