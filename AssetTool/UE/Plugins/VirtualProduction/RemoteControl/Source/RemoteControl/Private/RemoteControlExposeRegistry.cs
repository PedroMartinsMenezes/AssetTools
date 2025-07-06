namespace AssetTool
{
    [JsonAsset("RemoteControlExposeRegistry")]
    public class URemoteControlExposeRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferibleStruct("RCEntityWrapper")]
    public class FRCEntityWrapper : ITransferible
    {
        public FSoftObjectPath StructPath;
        public UScriptStruct ScriptStruct;

        [Location("bool FRCEntityWrapper::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StructPath);
            transfer.Move(ref ScriptStruct, x => x.SerializeItem(transfer));
            return this;
        }
    }
}