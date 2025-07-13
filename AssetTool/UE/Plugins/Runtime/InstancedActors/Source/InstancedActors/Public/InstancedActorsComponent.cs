namespace AssetTool
{
    [JsonAsset("InstancedActorsComponent")]
    public class UInstancedActorsComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}