namespace AssetTool
{
    [JsonAsset("LegacyCameraShake")]
    public class ULegacyCameraShake : UCameraShakeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LegacyCameraShakePattern", "MatineeCameraShakePattern")]
    public class ULegacyCameraShakePattern : UCameraShakePattern
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LegacyCameraShakeFunctionLibrary")]
    public class ULegacyCameraShakeFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}