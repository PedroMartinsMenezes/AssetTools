namespace AssetTool
{
    [JsonAsset("ChildActorComponent")]
    public class UChildActorComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}