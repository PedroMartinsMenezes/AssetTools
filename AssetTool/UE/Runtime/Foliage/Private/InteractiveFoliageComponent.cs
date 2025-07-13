namespace AssetTool
{
    [JsonAsset("InteractiveFoliageComponent")]
    public class UInteractiveFoliageComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}