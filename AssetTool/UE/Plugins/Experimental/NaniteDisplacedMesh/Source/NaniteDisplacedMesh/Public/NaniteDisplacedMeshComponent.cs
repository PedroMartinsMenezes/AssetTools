namespace AssetTool
{
    [JsonAsset("NaniteDisplacedMeshComponent")]
    public class UNaniteDisplacedMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}