namespace AssetTool
{
    [JsonAsset("LineSetComponent")]
    public class ULineSetComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}