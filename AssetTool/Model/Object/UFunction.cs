namespace AssetTool
{
    [Location("UFunction::Serialize( FArchive& Ar )")]
    [JsonAsset]
    public class UFunction : UStruct
    {
        public const string TypeName = "Function";

        public UInt32 FunctionFlags;
        public Int16 RepOffset;
        public UInt32 EventGraphFunction;
        public Int32 EventGraphCallOffset;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref FunctionFlags);

            if ((FunctionFlags & (uint)EFunctionFlags.FUNC_Net) == (uint)EFunctionFlags.FUNC_Net)
            {
                transfer.Move(ref RepOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_BLUEPRINT_EVENTGRAPH_FASTCALLS_IN_UFUNCTION))
            {
                transfer.Move(ref EventGraphFunction);
                transfer.Move(ref EventGraphCallOffset);
            }
            ///if ((Ar.GetPortFlags() & PPF_Duplicate) != 0)
            ///{
            ///    Ar << NumParms;
            ///    Ar << ParmsSize;
            ///    Ar << ReturnValueOffset;
            ///    Ar << FirstPropertyToInit;
            ///}

            return this;
        }
    }
}
