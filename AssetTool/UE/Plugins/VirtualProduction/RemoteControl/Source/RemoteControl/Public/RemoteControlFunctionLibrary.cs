namespace AssetTool
{
    [JsonAsset("RemoteControlFunctionLibrary")]
    public class URemoteControlFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}