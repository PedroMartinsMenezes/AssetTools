namespace AssetTool
{
    [JsonAsset("DefaultCameraShakeBase")]
    public class UDefaultCameraShakeBase : UCameraShakeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}