namespace AssetTool
{
    [JsonAsset("SceneComponent")]
    public class USceneComponent : UActorComponent
    {
        [Location("void USceneComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}