namespace AssetTool
{
    [JsonAsset("GroomComponent")]
    public class UGroomComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}