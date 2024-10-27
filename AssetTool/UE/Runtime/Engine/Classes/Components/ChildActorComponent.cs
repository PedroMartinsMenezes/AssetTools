namespace AssetTool
{
    [JsonAsset("ChildActorComponent")]
    public class UChildActorComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}