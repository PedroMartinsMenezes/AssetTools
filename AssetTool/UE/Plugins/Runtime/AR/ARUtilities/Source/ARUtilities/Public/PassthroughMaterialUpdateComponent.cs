namespace AssetTool
{
    [JsonAsset("PassthroughMaterialUpdateComponent")]
    public class UPassthroughMaterialUpdateComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}