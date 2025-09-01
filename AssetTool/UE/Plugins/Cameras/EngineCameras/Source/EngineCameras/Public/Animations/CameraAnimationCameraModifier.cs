namespace AssetTool
{
    [JsonAsset("CameraAnimationCameraModifier")]
    public class UCameraAnimationCameraModifier : UCameraModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EngineCameraAnimationFunctionLibrary")]
    public class UEngineCameraAnimationFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}