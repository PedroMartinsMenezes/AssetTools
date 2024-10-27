namespace AssetTool
{

    [JsonAsset("Function")]
    public class UFunction : UStruct
    {
        public UInt32 FunctionFlags;
        public Int16 RepOffset;
        public UInt32 EventGraphFunction;
        public Int32 EventGraphCallOffset;

        [Location("UFunction::Serialize( FArchive& Ar )")]
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

            return this;
        }
    }
}
