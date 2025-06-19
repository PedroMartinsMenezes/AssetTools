namespace AssetTool
{
    [JsonAsset("PlayerCameraManager")]
    public class APlayerCameraManager : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}