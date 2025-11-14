namespace AssetTool
{
    [JsonAsset("DefaultCameraShakeBase")]
    public class UDefaultCameraShakeBase : UCameraShakeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}