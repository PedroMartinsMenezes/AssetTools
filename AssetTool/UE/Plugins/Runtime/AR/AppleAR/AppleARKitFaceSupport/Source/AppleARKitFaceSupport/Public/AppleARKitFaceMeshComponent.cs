namespace AssetTool
{
    [JsonAsset("AppleARKitFaceMeshComponent")]
    public class UAppleARKitFaceMeshComponent : UProceduralMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}