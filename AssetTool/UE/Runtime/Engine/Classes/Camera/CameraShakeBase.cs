namespace AssetTool
{
    [JsonAsset("CameraShakeBase")]
    public class UCameraShakeBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraShakePattern")]
    public class UCameraShakePattern : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}