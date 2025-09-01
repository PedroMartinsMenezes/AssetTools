namespace AssetTool
{
    [JsonAsset("LegacyCameraShake")]
    public class ULegacyCameraShake : UCameraShakeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LegacyCameraShakePattern", "MatineeCameraShakePattern")]
    public class ULegacyCameraShakePattern : UCameraShakePattern
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LegacyCameraShakeFunctionLibrary")]
    public class ULegacyCameraShakeFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}