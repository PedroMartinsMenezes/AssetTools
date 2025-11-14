namespace AssetTool
{
    [JsonAsset("CameraAnimationCameraModifier")]
    public class UCameraAnimationCameraModifier : UCameraModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EngineCameraAnimationFunctionLibrary")]
    public class UEngineCameraAnimationFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}