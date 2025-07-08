namespace AssetTool
{
    [JsonAsset("HeadMountedDisplayFunctionLibrary")]
    public class UHeadMountedDisplayFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}