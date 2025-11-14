namespace AssetTool
{
    [JsonAsset("RemoteControlExposeRegistry")]
    public class URemoteControlExposeRegistry : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferableStruct("RCEntityWrapper")]
    public class FRCEntityWrapper : ITransferable
    {
        public FSoftObjectPath StructPath;
        public UScriptStruct ScriptStruct;

        [Location("bool FRCEntityWrapper::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref StructPath);
            transfer.Move(ref ScriptStruct, x => x.SerializeItem(transfer));
            return this;
        }
    }
}