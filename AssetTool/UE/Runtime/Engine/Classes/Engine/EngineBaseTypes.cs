namespace AssetTool
{
    [JsonAsset("ViewModeUtils")]
    public class UViewModeUtils : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EngineBaseTypes")]
    public class UEngineBaseTypes : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [Location("FArchive& operator<<( FArchive& Ar, FURL& U )")]
    public class FURL : ITransferible
    {
        public FString Protocol;
        public FString Host;
        public FString Map;
        public FString Portal;
        public List<FString> Op;
        public int32 Port;
        public int32 Valid;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Protocol);
            transfer.Move(ref Host);
            transfer.Move(ref Map);
            transfer.Move(ref Portal);
            transfer.Move(ref Op);
            transfer.Move(ref Port);
            transfer.Move(ref Valid);
            return this;
        }
    }
}