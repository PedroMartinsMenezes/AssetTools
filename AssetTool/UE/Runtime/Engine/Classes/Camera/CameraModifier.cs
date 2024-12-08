namespace AssetTool
{
    [JsonAsset("CameraModifier")]
    public class UCameraModifier : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}