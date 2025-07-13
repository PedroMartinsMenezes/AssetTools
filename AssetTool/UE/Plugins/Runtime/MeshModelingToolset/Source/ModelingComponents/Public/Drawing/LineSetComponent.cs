namespace AssetTool
{
    [JsonAsset("LineSetComponent")]
    public class ULineSetComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}