namespace AssetTool
{
    [JsonAsset("CableComponent")]
    public class UCableComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}