namespace AssetTool
{
    [JsonAsset("PassthroughMaterialUpdateComponent")]
    public class UPassthroughMaterialUpdateComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}