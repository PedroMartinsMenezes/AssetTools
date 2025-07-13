namespace AssetTool
{
    [JsonAsset("GroomComponent")]
    public class UGroomComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}