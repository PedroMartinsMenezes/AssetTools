namespace AssetTool
{
    [JsonAsset("AvaTransitionCameraLibrary")]
    public class UAvaTransitionCameraLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}