namespace AssetTool
{
    [JsonAsset("LightComponentBase")]
    public class ULightComponentBase : USceneComponent
    {
        [Location("void ULightComponentBase::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}