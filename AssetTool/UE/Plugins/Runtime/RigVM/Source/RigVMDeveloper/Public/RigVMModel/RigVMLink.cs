namespace AssetTool
{
    [JsonAsset("RigVMLink")]
    public class URigVMLink : UObject
    {
        public FString SourcePinPath;
        public FString TargetPinPath;

        [Location("void URigVMLink::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            transfer.Move(ref SourcePinPath);
            transfer.Move(ref TargetPinPath);
            return this;
        }
    }
}