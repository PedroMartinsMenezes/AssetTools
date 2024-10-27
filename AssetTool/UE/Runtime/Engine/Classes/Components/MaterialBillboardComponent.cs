namespace AssetTool
{
    [JsonAsset("MaterialBillboardComponent")]
    public class UMaterialBillboardComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}