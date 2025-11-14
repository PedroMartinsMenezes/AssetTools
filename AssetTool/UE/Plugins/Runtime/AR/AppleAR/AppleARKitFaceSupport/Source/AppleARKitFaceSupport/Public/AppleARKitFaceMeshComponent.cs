namespace AssetTool
{
    [JsonAsset("AppleARKitFaceMeshComponent")]
    public class UAppleARKitFaceMeshComponent : UProceduralMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}