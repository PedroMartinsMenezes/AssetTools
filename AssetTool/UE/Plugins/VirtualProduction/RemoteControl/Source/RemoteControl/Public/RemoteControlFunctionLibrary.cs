namespace AssetTool
{
    [JsonAsset("RemoteControlFunctionLibrary")]
    public class URemoteControlFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}