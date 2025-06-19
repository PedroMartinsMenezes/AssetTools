namespace AssetTool
{
    [JsonAsset("CableComponent")]
    public class UCableComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}