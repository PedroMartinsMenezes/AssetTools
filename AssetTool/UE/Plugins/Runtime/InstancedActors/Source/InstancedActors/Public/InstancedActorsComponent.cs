namespace AssetTool
{
    [JsonAsset("InstancedActorsComponent")]
    public class UInstancedActorsComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}