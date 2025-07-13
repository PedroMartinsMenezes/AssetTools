namespace AssetTool
{
    [JsonAsset("NaniteDisplacedMeshComponent")]
    public class UNaniteDisplacedMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}