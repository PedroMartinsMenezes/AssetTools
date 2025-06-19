namespace AssetTool
{
    [JsonAsset("CameraModifier")]
    public class UCameraModifier : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}