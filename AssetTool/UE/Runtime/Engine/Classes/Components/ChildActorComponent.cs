namespace AssetTool
{
    [JsonAsset("ChildActorComponent")]
    public class UChildActorComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}