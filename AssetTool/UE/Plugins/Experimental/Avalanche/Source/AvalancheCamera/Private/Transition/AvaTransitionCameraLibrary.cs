namespace AssetTool
{
    [JsonAsset("AvaTransitionCameraLibrary")]
    public class UAvaTransitionCameraLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}