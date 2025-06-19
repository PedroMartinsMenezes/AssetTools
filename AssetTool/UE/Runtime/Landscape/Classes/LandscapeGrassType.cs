namespace AssetTool
{
    [JsonAsset("LandscapeGrassType")]
    public class ULandscapeGrassType : UObject, ITransferible
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        ITransferible ITransferible.Move(Transfer transfer)
        {
            return (ITransferible)base.Move(transfer);
        }
    }
}