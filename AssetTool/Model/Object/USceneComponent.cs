namespace AssetTool
{
    [Location("void USceneComponent::Serialize(FArchive& Ar)")]
    public class USceneComponent : UActorComponent
    {
        public const string TypeName = "SceneComponent";

        public new USceneComponent Move(Transfer transfer) => (USceneComponent)base.Move(transfer);
    }
}
