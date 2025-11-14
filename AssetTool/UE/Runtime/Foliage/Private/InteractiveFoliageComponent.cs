namespace AssetTool
{
    [JsonAsset("InteractiveFoliageComponent")]
    public class UInteractiveFoliageComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}