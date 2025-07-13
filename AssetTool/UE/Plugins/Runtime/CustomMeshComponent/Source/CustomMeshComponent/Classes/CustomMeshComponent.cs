namespace AssetTool
{
    [JsonAsset("CustomMeshComponent")]
    public class UCustomMeshComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}