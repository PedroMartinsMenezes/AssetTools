namespace AssetTool
{
    [JsonAsset("PlayerCameraManager")]
    public class APlayerCameraManager : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}