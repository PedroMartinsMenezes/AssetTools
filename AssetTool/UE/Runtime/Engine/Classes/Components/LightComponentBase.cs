namespace AssetTool
{
    [JsonAsset("LightComponentBase")]
    public class ULightComponentBase : USceneComponent
    {
        [Location("void ULightComponentBase::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}